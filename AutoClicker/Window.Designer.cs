namespace AutoClicker
{
	partial class Window
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.lblInterval = new System.Windows.Forms.Label();
			this.tmrClicker = new System.Windows.Forms.Timer(this.components);
			this.nudInterval = new System.Windows.Forms.NumericUpDown();
			this.tmrKeyDown = new System.Windows.Forms.Timer(this.components);
			this.lblHint = new System.Windows.Forms.Label();
			this.pnlUserTimeFrame = new System.Windows.Forms.Panel();
			this.lblUserTimeFrame = new System.Windows.Forms.Label();
			this.btn30sec = new System.Windows.Forms.Button();
			this.btn1min = new System.Windows.Forms.Button();
			this.btn5min = new System.Windows.Forms.Button();
			this.lblCalculate = new System.Windows.Forms.Label();
			this.nudInputTime = new System.Windows.Forms.NumericUpDown();
			this.cbTimeUnit = new System.Windows.Forms.ComboBox();
			this.lblStandardTimeFrame = new System.Windows.Forms.Label();
			this.pnlTimeCalculator = new System.Windows.Forms.Panel();
			this.tbCalcResult = new System.Windows.Forms.TextBox();
			this.pnlInteractClicker = new System.Windows.Forms.Panel();
			this.pnlStandardTimeFrame = new System.Windows.Forms.Panel();
			this.btnChangeWindowState = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
			this.pnlUserTimeFrame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudInputTime)).BeginInit();
			this.pnlTimeCalculator.SuspendLayout();
			this.pnlInteractClicker.SuspendLayout();
			this.pnlStandardTimeFrame.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStartStop
			// 
			this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnStartStop.AutoSize = true;
			this.btnStartStop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStartStop.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartStop.Location = new System.Drawing.Point(43, 4);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(140, 30);
			this.btnStartStop.TabIndex = 0;
			this.btnStartStop.Text = "Start Auto Click";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
			// 
			// lblInterval
			// 
			this.lblInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblInterval.AutoSize = true;
			this.lblInterval.Font = new System.Drawing.Font("Bahnschrift", 11F);
			this.lblInterval.Location = new System.Drawing.Point(16, 25);
			this.lblInterval.Name = "lblInterval";
			this.lblInterval.Size = new System.Drawing.Size(97, 18);
			this.lblInterval.TabIndex = 1;
			this.lblInterval.Text = "Interval (ms):";
			// 
			// tmrClicker
			// 
			this.tmrClicker.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// nudInterval
			// 
			this.nudInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.nudInterval.AutoSize = true;
			this.nudInterval.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudInterval.Location = new System.Drawing.Point(115, 23);
			this.nudInterval.Maximum = new decimal(new int[] {
            2400000,
            0,
            0,
            0});
			this.nudInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudInterval.Name = "nudInterval";
			this.nudInterval.Size = new System.Drawing.Size(87, 26);
			this.nudInterval.TabIndex = 2;
			this.nudInterval.Tag = "interval";
			this.nudInterval.Value = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			this.nudInterval.ValueChanged += new System.EventHandler(this.nudInput_ValueChanged);
			// 
			// tmrKeyDown
			// 
			this.tmrKeyDown.Enabled = true;
			this.tmrKeyDown.Tick += new System.EventHandler(this.tmrKeyDown_Tick);
			// 
			// lblHint
			// 
			this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHint.AutoSize = true;
			this.lblHint.Font = new System.Drawing.Font("Bahnschrift", 11F);
			this.lblHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblHint.Location = new System.Drawing.Point(4, 37);
			this.lblHint.Name = "lblHint";
			this.lblHint.Size = new System.Drawing.Size(209, 18);
			this.lblHint.TabIndex = 3;
			this.lblHint.Text = "Press Right Shift to start/stop";
			// 
			// pnlUserTimeFrame
			// 
			this.pnlUserTimeFrame.Controls.Add(this.nudInterval);
			this.pnlUserTimeFrame.Controls.Add(this.lblUserTimeFrame);
			this.pnlUserTimeFrame.Controls.Add(this.lblInterval);
			this.pnlUserTimeFrame.Location = new System.Drawing.Point(1, 2);
			this.pnlUserTimeFrame.Name = "pnlUserTimeFrame";
			this.pnlUserTimeFrame.Size = new System.Drawing.Size(216, 55);
			this.pnlUserTimeFrame.TabIndex = 4;
			// 
			// lblUserTimeFrame
			// 
			this.lblUserTimeFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUserTimeFrame.AutoSize = true;
			this.lblUserTimeFrame.Font = new System.Drawing.Font("Bahnschrift", 11F);
			this.lblUserTimeFrame.Location = new System.Drawing.Point(16, 3);
			this.lblUserTimeFrame.Name = "lblUserTimeFrame";
			this.lblUserTimeFrame.Size = new System.Drawing.Size(176, 18);
			this.lblUserTimeFrame.TabIndex = 3;
			this.lblUserTimeFrame.Text = "User-defined time frame:";
			// 
			// btn30sec
			// 
			this.btn30sec.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn30sec.AutoSize = true;
			this.btn30sec.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn30sec.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn30sec.Location = new System.Drawing.Point(10, 21);
			this.btn30sec.Name = "btn30sec";
			this.btn30sec.Size = new System.Drawing.Size(65, 30);
			this.btn30sec.TabIndex = 5;
			this.btn30sec.Text = "30 sec";
			this.btn30sec.UseVisualStyleBackColor = true;
			this.btn30sec.Click += new System.EventHandler(this.btnStandardTimeFrame_Click);
			// 
			// btn1min
			// 
			this.btn1min.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn1min.AutoSize = true;
			this.btn1min.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn1min.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1min.Location = new System.Drawing.Point(81, 21);
			this.btn1min.Name = "btn1min";
			this.btn1min.Size = new System.Drawing.Size(65, 30);
			this.btn1min.TabIndex = 6;
			this.btn1min.Text = "1 min";
			this.btn1min.UseVisualStyleBackColor = true;
			this.btn1min.Click += new System.EventHandler(this.btnStandardTimeFrame_Click);
			// 
			// btn5min
			// 
			this.btn5min.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn5min.AutoSize = true;
			this.btn5min.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn5min.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5min.Location = new System.Drawing.Point(152, 21);
			this.btn5min.Name = "btn5min";
			this.btn5min.Size = new System.Drawing.Size(65, 30);
			this.btn5min.TabIndex = 7;
			this.btn5min.Text = "5 min";
			this.btn5min.UseVisualStyleBackColor = true;
			this.btn5min.Click += new System.EventHandler(this.btnStandardTimeFrame_Click);
			// 
			// lblCalculate
			// 
			this.lblCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCalculate.AutoSize = true;
			this.lblCalculate.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
			this.lblCalculate.Location = new System.Drawing.Point(11, 36);
			this.lblCalculate.Name = "lblCalculate";
			this.lblCalculate.Size = new System.Drawing.Size(64, 18);
			this.lblCalculate.TabIndex = 3;
			this.lblCalculate.Text = "in ms is:";
			// 
			// nudInputTime
			// 
			this.nudInputTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.nudInputTime.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudInputTime.Location = new System.Drawing.Point(10, 4);
			this.nudInputTime.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
			this.nudInputTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudInputTime.Name = "nudInputTime";
			this.nudInputTime.Size = new System.Drawing.Size(61, 26);
			this.nudInputTime.TabIndex = 3;
			this.nudInputTime.Tag = "calculate";
			this.nudInputTime.Value = new decimal(new int[] {
            2400,
            0,
            0,
            0});
			this.nudInputTime.ValueChanged += new System.EventHandler(this.nudInput_ValueChanged);
			// 
			// cbTimeUnit
			// 
			this.cbTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTimeUnit.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
			this.cbTimeUnit.FormattingEnabled = true;
			this.cbTimeUnit.Items.AddRange(new object[] {
            "minute(s)",
            "second(s)"});
			this.cbTimeUnit.Location = new System.Drawing.Point(81, 4);
			this.cbTimeUnit.Name = "cbTimeUnit";
			this.cbTimeUnit.Size = new System.Drawing.Size(136, 26);
			this.cbTimeUnit.TabIndex = 8;
			this.cbTimeUnit.DropDownClosed += new System.EventHandler(this.cbTimes_DropDownClosed);
			// 
			// lblStandardTimeFrame
			// 
			this.lblStandardTimeFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblStandardTimeFrame.AutoSize = true;
			this.lblStandardTimeFrame.Font = new System.Drawing.Font("Bahnschrift", 11F);
			this.lblStandardTimeFrame.Location = new System.Drawing.Point(14, 2);
			this.lblStandardTimeFrame.Name = "lblStandardTimeFrame";
			this.lblStandardTimeFrame.Size = new System.Drawing.Size(149, 18);
			this.lblStandardTimeFrame.TabIndex = 9;
			this.lblStandardTimeFrame.Text = "Standard time frame:";
			// 
			// pnlTimeCalculator
			// 
			this.pnlTimeCalculator.Controls.Add(this.tbCalcResult);
			this.pnlTimeCalculator.Controls.Add(this.nudInputTime);
			this.pnlTimeCalculator.Controls.Add(this.lblCalculate);
			this.pnlTimeCalculator.Controls.Add(this.cbTimeUnit);
			this.pnlTimeCalculator.Location = new System.Drawing.Point(216, 56);
			this.pnlTimeCalculator.Name = "pnlTimeCalculator";
			this.pnlTimeCalculator.Size = new System.Drawing.Size(220, 62);
			this.pnlTimeCalculator.TabIndex = 10;
			// 
			// tbCalcResult
			// 
			this.tbCalcResult.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
			this.tbCalcResult.Location = new System.Drawing.Point(81, 33);
			this.tbCalcResult.Name = "tbCalcResult";
			this.tbCalcResult.ReadOnly = true;
			this.tbCalcResult.Size = new System.Drawing.Size(136, 26);
			this.tbCalcResult.TabIndex = 9;
			// 
			// pnlInteractClicker
			// 
			this.pnlInteractClicker.Controls.Add(this.btnStartStop);
			this.pnlInteractClicker.Controls.Add(this.lblHint);
			this.pnlInteractClicker.Location = new System.Drawing.Point(1, 56);
			this.pnlInteractClicker.Name = "pnlInteractClicker";
			this.pnlInteractClicker.Size = new System.Drawing.Size(216, 62);
			this.pnlInteractClicker.TabIndex = 11;
			// 
			// pnlStandardTimeFrame
			// 
			this.pnlStandardTimeFrame.Controls.Add(this.lblStandardTimeFrame);
			this.pnlStandardTimeFrame.Controls.Add(this.btn30sec);
			this.pnlStandardTimeFrame.Controls.Add(this.btn1min);
			this.pnlStandardTimeFrame.Controls.Add(this.btn5min);
			this.pnlStandardTimeFrame.Location = new System.Drawing.Point(216, 2);
			this.pnlStandardTimeFrame.Name = "pnlStandardTimeFrame";
			this.pnlStandardTimeFrame.Size = new System.Drawing.Size(220, 55);
			this.pnlStandardTimeFrame.TabIndex = 12;
			// 
			// btnChangeWindowState
			// 
			this.btnChangeWindowState.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChangeWindowState.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnChangeWindowState.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangeWindowState.Location = new System.Drawing.Point(436, 0);
			this.btnChangeWindowState.Name = "btnChangeWindowState";
			this.btnChangeWindowState.Size = new System.Drawing.Size(18, 119);
			this.btnChangeWindowState.TabIndex = 10;
			this.btnChangeWindowState.Text = "<<";
			this.btnChangeWindowState.UseVisualStyleBackColor = true;
			this.btnChangeWindowState.Click += new System.EventHandler(this.btnChangeWindowState_Click);
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 119);
			this.Controls.Add(this.btnChangeWindowState);
			this.Controls.Add(this.pnlStandardTimeFrame);
			this.Controls.Add(this.pnlInteractClicker);
			this.Controls.Add(this.pnlTimeCalculator);
			this.Controls.Add(this.pnlUserTimeFrame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(16, 39);
			this.Name = "Window";
			this.ShowIcon = false;
			this.Text = "Auto Clicker";
			this.Load += new System.EventHandler(this.Window_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
			this.pnlUserTimeFrame.ResumeLayout(false);
			this.pnlUserTimeFrame.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudInputTime)).EndInit();
			this.pnlTimeCalculator.ResumeLayout(false);
			this.pnlTimeCalculator.PerformLayout();
			this.pnlInteractClicker.ResumeLayout(false);
			this.pnlInteractClicker.PerformLayout();
			this.pnlStandardTimeFrame.ResumeLayout(false);
			this.pnlStandardTimeFrame.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.Timer tmrClicker;
		private System.Windows.Forms.NumericUpDown nudInterval;
		private System.Windows.Forms.Timer tmrKeyDown;
		private System.Windows.Forms.Label lblHint;
		private System.Windows.Forms.Panel pnlUserTimeFrame;
		private System.Windows.Forms.Button btn30sec;
		private System.Windows.Forms.Button btn1min;
		private System.Windows.Forms.Button btn5min;
		private System.Windows.Forms.Label lblCalculate;
		private System.Windows.Forms.NumericUpDown nudInputTime;
		private System.Windows.Forms.ComboBox cbTimeUnit;
		private System.Windows.Forms.Label lblUserTimeFrame;
		private System.Windows.Forms.Label lblStandardTimeFrame;
		private System.Windows.Forms.Panel pnlTimeCalculator;
		private System.Windows.Forms.Panel pnlInteractClicker;
		private System.Windows.Forms.Panel pnlStandardTimeFrame;
		private System.Windows.Forms.TextBox tbCalcResult;
		private System.Windows.Forms.Button btnChangeWindowState;
	}
}

