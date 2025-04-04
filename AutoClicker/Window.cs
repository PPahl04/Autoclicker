using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
		State _windowState;
		Key _startStopKey;
		Button[] _timeFrames;

		public Window()
		{
			InitializeComponent();

			_startStopKey = Key.RightShift;
			_windowState = State.HideExtended;
			_timeFrames = new Button[3] 
			{
				btn30sec,
				btn1min, 
				btn5min
			};
		}

		enum MouseEventsFlags
		{
			LeftDown = 2,
			LeftUp = 4,
		}

		enum State
		{
			HideExtended,
			ShowExtended
		}
		
		void Window_Load(object sender, EventArgs e)
		{
			tmrKeyDown.Start();
			_intervalToUse = (int)nudInterval.Value;
			cbTimeUnit.SelectedIndex = 0;
			ChangeWindow();
		}

		void LeftClick(Point p)
		{
			mouse_event((int)MouseEventsFlags.LeftDown, p.X, p.Y, 0, 0);
			mouse_event((int)MouseEventsFlags.LeftUp, p.X, p.Y, 0, 0);
		}

		void btnStartStop_Click(object sender, EventArgs e)
		{
			ChangeActiveState();
		}

		/// <summary>
		/// Will start/stop the timer based on if the clicker is active or not.
		/// </summary>
		void ChangeActiveState()
		{
			_clickerIsActive = !_clickerIsActive;
			tmrClicker.Interval = _intervalToUse;
			tmrClicker.Enabled = true;

			if (_clickerIsActive)
			{
				btnStartStop.Text = "Stop Autoclicker";
				tmrClicker.Start();
			}
			else
			{
				btnStartStop.Text = "Start Autoclicker";
				tmrClicker.Stop();
			}
		}

		/// <summary>
		/// Event that will trigger the click method if raised.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void timer_Tick(object sender, EventArgs e)
		{
			LeftClick(new Point(MousePosition.X, MousePosition.Y));
		}
		
		/// <summary>
		/// Will check if the user has pressed the start/stop key during runtime
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void tmrKeyDown_Tick(object sender, EventArgs e)
		{
			if (Keyboard.IsKeyDown(_startStopKey))
			{
				ChangeActiveState();
			}
		}

		/// <summary>
		/// Will set up the timers interval to the desired buttons data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void btnStandardTimeFrame_Click(object sender, EventArgs e)
		{
			Button senderButton = (Button)sender;
			string[] btnData = senderButton.Text.Split();

			int timeFrame = Convert.ToInt32(btnData[0]);
			string timeUnit = btnData[1];

			timeUnit = DetermineNextTimeUnit(timeUnit);
			_intervalToUse = CalculateToMilliSeconds(timeFrame, timeUnit);

			senderButton.Enabled = false;
			Button[] uninteractedBtns = _timeFrames.Where(btn => btn != senderButton).ToArray();
			foreach(Button btn in uninteractedBtns)
			{
				btn.Enabled = true;
			}
		}

		/// <summary>
		/// Returns the time frame the selected time frame needs to be converted to.
		/// </summary>
		/// <param name="timeUnit"></param>
		/// <returns></returns>
		string DetermineNextTimeUnit(string timeUnit)
		{
			switch(timeUnit)
			{
				case "minute(s)":
				case "min":
					timeUnit = "sec";
				break;
			
				case "second(s)":
				case "sec":
					timeUnit = "ms";
				break;
			}

			return timeUnit;
		}

		int CalculateToMilliSeconds(int myTimeFrame, string myNextTimeUnit)
		{
			// convert min to sec
			if (myNextTimeUnit.Equals("sec"))
			{
				myTimeFrame *= 60;
				myNextTimeUnit = "ms";
			}

			// convert sec to ms
			if (myNextTimeUnit.Equals("ms"))
			{
				myTimeFrame *= 1000;
			}

			return myTimeFrame;
		}

		void cbTimes_ValueChanged(object sender, EventArgs e)
		{
			CalculateResult();
		}

		/// <summary>
		/// Event that handles the nuds whose value have changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void nudInput_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown nudSender = (NumericUpDown)sender;
			if (nudSender == nudInputTime)
			{
				CalculateResult();
			}
			else if (nudSender == nudInterval)
			{
				_intervalToUse = (int)nudSender.Value;
				
				foreach (Button btn in _timeFrames)
				{
					btn.Enabled = true;
				}

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

		void btnChangeWindowState_Click(object sender, EventArgs e)
		{
			_windowState = _windowState == State.HideExtended ? State.ShowExtended : State.HideExtended;
			ChangeWindow();
		}

		/// <summary>
		/// This will either widen the window to show its other options or reduce it to show its main functions.
		/// </summary>
		void ChangeWindow()
		{
			if (_windowState == State.HideExtended)
			{
				Width = pnlInteractClicker.Width + btnChangeWindowState.Width * 2;
				pnlStandardTimeFrame.Visible = false;
				pnlTimeCalculator.Visible = false;
				btnChangeWindowState.Text = ">>";
			}
			else if (_windowState == State.ShowExtended)
			{
				pnlStandardTimeFrame.Visible = true;
				pnlTimeCalculator.Visible = true;
				Width = 470;
				btnChangeWindowState.Text = "<<";
			}
		}
	}
}