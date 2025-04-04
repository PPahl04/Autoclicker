using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;

namespace AutoClicker
{
	public partial class Window : Form
	{
		[DllImport("user32.dll")]
		static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwextrainfo);
		
		bool _clickerIsActive;
		int _intervalToUse;
		State _windowState = State.HideExtended;
		Key _startStopKey = Key.RightShift;

		public Window()
		{
			InitializeComponent();
		}

		private enum MouseEventsFlags
		{
			LeftDown = 2,
			LeftUp = 4,
		}

		private void LeftClick(Point p)
		{
			mouse_event((int)MouseEventsFlags.LeftDown, p.X, p.Y, 0, 0);
			mouse_event((int)MouseEventsFlags.LeftUp, p.X, p.Y, 0, 0);
		}

		private void btnStartStop_Click(object sender, EventArgs e)
		{
			ChangeActiveState();
		}

		private void ChangeActiveState()
		{
			_clickerIsActive = !_clickerIsActive;
			tmrClicker.Interval = _intervalToUse;
			tmrClicker.Enabled = true;

			if (_clickerIsActive)
			{
				btnStartStop.Text = "Stop Auto Click";
				tmrClicker.Start();
			}
			else
			{
				btnStartStop.Text = "Start Auto CLick";
				tmrClicker.Stop();
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			LeftClick(new Point(MousePosition.X, MousePosition.Y));
		}

		private void tmrKeyDown_Tick(object sender, EventArgs e)
		{
			if (Keyboard.IsKeyDown(_startStopKey))
			{
				ChangeActiveState();
			}
		}

		private void Window_Load(object sender, EventArgs e)
		{
			tmrKeyDown.Start();
			_intervalToUse = (int)nudInterval.Value;
			cbTimeUnit.SelectedIndex = 0;
			ChangeWindow();
		}

		private void btnStandardTimeFrame_Click(object sender, EventArgs e)
		{
			Button senderButton = (Button)sender;
			Regex rgxLetters = new Regex(@"[a-z]+");
			Regex rgxDigits = new Regex(@"\d+");

			string timeUnit = rgxLetters.Match(senderButton.Text).Value;
			int timeFrame = Convert.ToInt32(rgxDigits.Match(senderButton.Text).Value);

			timeUnit = DetermineNextTimeUnit(timeUnit);
			_intervalToUse = (int)CalculateToMilliSeconds(timeFrame, timeUnit);

			switch (timeFrame)
			{
				case 30:
					btn30sec.Enabled = false;
					btn1min.Enabled = true;
					btn5min.Enabled = true;
					break;
				
				case 1:
					btn30sec.Enabled = true;
					btn1min.Enabled = false;
					btn5min.Enabled = true;
				break;
				
				case 5:
					btn30sec.Enabled = true;
					btn1min.Enabled = true;
					btn5min.Enabled = false;
				break;
			}
		}

		string DetermineNextTimeUnit(string timeUnit)
		{
			switch(timeUnit)
			{
				case "minute(s)":
				case "min":
					timeUnit = "Second";
				break;
			
				case "second(s)":
				case "sec":
					timeUnit = "Millisecond";
				break;
			}

			return timeUnit;
		}

		int CalculateToMilliSeconds(int timeFrame, string nextTimeUnit)
		{
			if (nextTimeUnit.Equals("Minute"))
			{
				timeFrame *= 60;
				nextTimeUnit = "Second";
			}

			if (nextTimeUnit.Equals("Second"))
			{
				timeFrame *= 60;
				nextTimeUnit = "Millisecond";
			}

			if (nextTimeUnit.Equals("Millisecond"))
			{
				timeFrame *= 1000;
			}

			return timeFrame;
		}

		private void cbTimes_DropDownClosed(object sender, EventArgs e)
		{
			CalculateResult();
		}

		private void nudInput_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown nudSender = (NumericUpDown)sender;
			if (nudSender.Tag.Equals(nudInputTime.Tag))
			{
				CalculateResult();
			}
			else if (nudSender.Tag.Equals(nudInterval.Tag))
			{
				_intervalToUse = (int)nudSender.Value;
				btn30sec.Enabled = true;
				btn1min.Enabled = true;
				btn5min.Enabled = true;

				if (_clickerIsActive)
				{
					ChangeActiveState();
				}
			}
		}

		void CalculateResult()
		{
			string nextTimeUnit = DetermineNextTimeUnit(cbTimeUnit.Text);
			int timeFrame = (int)nudInputTime.Value;
			int result = CalculateToMilliSeconds(timeFrame, nextTimeUnit);
			tbCalcResult.Text = result > 0 ? result.ToString() : "ERROR" ;
		}

		enum State
		{
			HideExtended,
			ShowExtended
		}

		private void btnChangeWindowState_Click(object sender, EventArgs e)
		{
			_windowState = (int)_windowState == 0 ? State.ShowExtended : State.HideExtended;
			ChangeWindow();
		}

		void ChangeWindow()
		{
			if (_windowState == State.HideExtended)
			{
				this.Width = pnlInteractClicker.Width + btnChangeWindowState.Width * 2;
				pnlStandardTimeFrame.Visible = false;
				pnlTimeCalculator.Visible = false;
				btnChangeWindowState.Text = ">>";
			}
			else
			{
				pnlStandardTimeFrame.Visible = true;
				pnlTimeCalculator.Visible = true;
				this.Width = 470;
				btnChangeWindowState.Text = "<<";
			}
		}
	}
}