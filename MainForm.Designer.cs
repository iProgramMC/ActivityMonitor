
namespace ActivityMonitor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.foreground_wnd_label = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.ActListView = new System.Windows.Forms.ListView();
            this.LastUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImagePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabActLog = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TabSummary = new System.Windows.Forms.TabPage();
            this.labelCurrentTaskSwitches = new System.Windows.Forms.Label();
            this.labelCurrentRuntime = new System.Windows.Forms.Label();
            this.labelTaskSwitches = new System.Windows.Forms.Label();
            this.labelRuntime = new System.Windows.Forms.Label();
            this.TabAnalytics = new System.Windows.Forms.TabPage();
            this.ButtonRefreshAnalytics = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AnalyticsLV = new System.Windows.Forms.ListView();
            this.ApplicationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ApplicationFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SwitchesTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalUsageTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TodayUsageTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.buttonLoadUsageData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonHideWindow = new System.Windows.Forms.Button();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.buttonClearUsageData = new System.Windows.Forms.Button();
            this.ButtonDebugPrintAll = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.TabActLog.SuspendLayout();
            this.TabSummary.SuspendLayout();
            this.TabAnalytics.SuspendLayout();
            this.TabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreground_wnd_label
            // 
            this.foreground_wnd_label.AutoSize = true;
            this.foreground_wnd_label.Location = new System.Drawing.Point(12, 9);
            this.foreground_wnd_label.Name = "foreground_wnd_label";
            this.foreground_wnd_label.Size = new System.Drawing.Size(167, 13);
            this.foreground_wnd_label.TabIndex = 0;
            this.foreground_wnd_label.Text = "Current foreground window: (TBA)";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // ActListView
            // 
            this.ActListView.AllowColumnReorder = true;
            this.ActListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LastUsed,
            this.FirstUsed,
            this.PID,
            this.NameColmn,
            this.ImagePath});
            this.ActListView.GridLines = true;
            this.ActListView.HideSelection = false;
            this.ActListView.Location = new System.Drawing.Point(6, 19);
            this.ActListView.Name = "ActListView";
            this.ActListView.Size = new System.Drawing.Size(629, 360);
            this.ActListView.TabIndex = 1;
            this.ActListView.UseCompatibleStateImageBehavior = false;
            this.ActListView.View = System.Windows.Forms.View.Details;
            // 
            // LastUsed
            // 
            this.LastUsed.Text = "Last Used";
            this.LastUsed.Width = 120;
            // 
            // FirstUsed
            // 
            this.FirstUsed.Text = "First Used";
            this.FirstUsed.Width = 120;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            // 
            // NameColmn
            // 
            this.NameColmn.Text = "Name";
            this.NameColmn.Width = 300;
            // 
            // ImagePath
            // 
            this.ImagePath.Text = "Image Path";
            this.ImagePath.Width = 100;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TabActLog);
            this.TabControl.Controls.Add(this.TabSummary);
            this.TabControl.Controls.Add(this.TabAnalytics);
            this.TabControl.Controls.Add(this.TabSettings);
            this.TabControl.Location = new System.Drawing.Point(15, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(649, 411);
            this.TabControl.TabIndex = 1;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // TabActLog
            // 
            this.TabActLog.Controls.Add(this.label1);
            this.TabActLog.Controls.Add(this.ActListView);
            this.TabActLog.Location = new System.Drawing.Point(4, 22);
            this.TabActLog.Name = "TabActLog";
            this.TabActLog.Padding = new System.Windows.Forms.Padding(3);
            this.TabActLog.Size = new System.Drawing.Size(641, 385);
            this.TabActLog.TabIndex = 0;
            this.TabActLog.Text = "Activity Log";
            this.TabActLog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This table updates live.  Task switches marked in beige are from previous session" +
    "s.";
            // 
            // TabSummary
            // 
            this.TabSummary.Controls.Add(this.labelCurrentTaskSwitches);
            this.TabSummary.Controls.Add(this.labelCurrentRuntime);
            this.TabSummary.Controls.Add(this.labelTaskSwitches);
            this.TabSummary.Controls.Add(this.labelRuntime);
            this.TabSummary.Location = new System.Drawing.Point(4, 22);
            this.TabSummary.Name = "TabSummary";
            this.TabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.TabSummary.Size = new System.Drawing.Size(641, 385);
            this.TabSummary.TabIndex = 1;
            this.TabSummary.Text = "Summary";
            this.TabSummary.UseVisualStyleBackColor = true;
            // 
            // labelCurrentTaskSwitches
            // 
            this.labelCurrentTaskSwitches.AutoSize = true;
            this.labelCurrentTaskSwitches.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTaskSwitches.Location = new System.Drawing.Point(6, 72);
            this.labelCurrentTaskSwitches.Name = "labelCurrentTaskSwitches";
            this.labelCurrentTaskSwitches.Size = new System.Drawing.Size(384, 23);
            this.labelCurrentTaskSwitches.TabIndex = 3;
            this.labelCurrentTaskSwitches.Text = "Task switches in current session:(TBA)";
            // 
            // labelCurrentRuntime
            // 
            this.labelCurrentRuntime.AutoSize = true;
            this.labelCurrentRuntime.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentRuntime.Location = new System.Drawing.Point(6, 49);
            this.labelCurrentRuntime.Name = "labelCurrentRuntime";
            this.labelCurrentRuntime.Size = new System.Drawing.Size(332, 23);
            this.labelCurrentRuntime.TabIndex = 2;
            this.labelCurrentRuntime.Text = "Runtime in current session:(TBA)";
            // 
            // labelTaskSwitches
            // 
            this.labelTaskSwitches.AutoSize = true;
            this.labelTaskSwitches.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskSwitches.Location = new System.Drawing.Point(6, 26);
            this.labelTaskSwitches.Name = "labelTaskSwitches";
            this.labelTaskSwitches.Size = new System.Drawing.Size(263, 23);
            this.labelTaskSwitches.TabIndex = 1;
            this.labelTaskSwitches.Text = "Total task switches: (TBA)";
            // 
            // labelRuntime
            // 
            this.labelRuntime.AutoSize = true;
            this.labelRuntime.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuntime.Location = new System.Drawing.Point(6, 3);
            this.labelRuntime.Name = "labelRuntime";
            this.labelRuntime.Size = new System.Drawing.Size(209, 23);
            this.labelRuntime.TabIndex = 0;
            this.labelRuntime.Text = "Total runtime: (TBA)";
            // 
            // TabAnalytics
            // 
            this.TabAnalytics.Controls.Add(this.ButtonRefreshAnalytics);
            this.TabAnalytics.Controls.Add(this.label2);
            this.TabAnalytics.Controls.Add(this.AnalyticsLV);
            this.TabAnalytics.Location = new System.Drawing.Point(4, 22);
            this.TabAnalytics.Name = "TabAnalytics";
            this.TabAnalytics.Size = new System.Drawing.Size(641, 385);
            this.TabAnalytics.TabIndex = 3;
            this.TabAnalytics.Text = "Analytics";
            this.TabAnalytics.UseVisualStyleBackColor = true;
            // 
            // ButtonRefreshAnalytics
            // 
            this.ButtonRefreshAnalytics.Location = new System.Drawing.Point(563, 3);
            this.ButtonRefreshAnalytics.Name = "ButtonRefreshAnalytics";
            this.ButtonRefreshAnalytics.Size = new System.Drawing.Size(75, 23);
            this.ButtonRefreshAnalytics.TabIndex = 2;
            this.ButtonRefreshAnalytics.Text = "Refresh";
            this.ButtonRefreshAnalytics.UseVisualStyleBackColor = true;
            this.ButtonRefreshAnalytics.Click += new System.EventHandler(this.ButtonRefreshAnalytics_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unlike the Activity Log, this does not update live.  To refresh, click the Refres" +
    "h button or re-switch to this tab.";
            // 
            // AnalyticsLV
            // 
            this.AnalyticsLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnalyticsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ApplicationName,
            this.ApplicationFilePath,
            this.SwitchesTo,
            this.TotalUsageTime,
            this.TodayUsageTime});
            this.AnalyticsLV.HideSelection = false;
            this.AnalyticsLV.Location = new System.Drawing.Point(3, 32);
            this.AnalyticsLV.Name = "AnalyticsLV";
            this.AnalyticsLV.Size = new System.Drawing.Size(635, 350);
            this.AnalyticsLV.TabIndex = 0;
            this.AnalyticsLV.UseCompatibleStateImageBehavior = false;
            this.AnalyticsLV.View = System.Windows.Forms.View.Details;
            // 
            // ApplicationName
            // 
            this.ApplicationName.Text = "Application Title";
            this.ApplicationName.Width = 150;
            // 
            // ApplicationFilePath
            // 
            this.ApplicationFilePath.Text = "File Path";
            // 
            // SwitchesTo
            // 
            this.SwitchesTo.Text = "Nr. of switches to this task";
            this.SwitchesTo.Width = 140;
            // 
            // TotalUsageTime
            // 
            this.TotalUsageTime.Text = "Total usage time";
            this.TotalUsageTime.Width = 120;
            // 
            // TodayUsageTime
            // 
            this.TodayUsageTime.Text = "Usage time today";
            this.TodayUsageTime.Width = 120;
            // 
            // TabSettings
            // 
            this.TabSettings.Controls.Add(this.label3);
            this.TabSettings.Controls.Add(this.buttonLoadUsageData);
            this.TabSettings.Controls.Add(this.button1);
            this.TabSettings.Controls.Add(this.ButtonHideWindow);
            this.TabSettings.Controls.Add(this.ButtonAbout);
            this.TabSettings.Controls.Add(this.buttonClearUsageData);
            this.TabSettings.Controls.Add(this.ButtonDebugPrintAll);
            this.TabSettings.Location = new System.Drawing.Point(4, 22);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabSettings.Size = new System.Drawing.Size(641, 385);
            this.TabSettings.TabIndex = 2;
            this.TabSettings.Text = "Settings";
            this.TabSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLoadUsageData
            // 
            this.buttonLoadUsageData.Location = new System.Drawing.Point(6, 107);
            this.buttonLoadUsageData.Name = "buttonLoadUsageData";
            this.buttonLoadUsageData.Size = new System.Drawing.Size(285, 23);
            this.buttonLoadUsageData.TabIndex = 5;
            this.buttonLoadUsageData.Text = "Import usage data";
            this.buttonLoadUsageData.UseVisualStyleBackColor = true;
            this.buttonLoadUsageData.Click += new System.EventHandler(this.buttonLoadUsageData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export usage data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSaveUsageData_Click);
            // 
            // ButtonHideWindow
            // 
            this.ButtonHideWindow.Location = new System.Drawing.Point(6, 35);
            this.ButtonHideWindow.Name = "ButtonHideWindow";
            this.ButtonHideWindow.Size = new System.Drawing.Size(285, 23);
            this.ButtonHideWindow.TabIndex = 3;
            this.ButtonHideWindow.Text = "Hide in background (hides window)";
            this.ButtonHideWindow.UseVisualStyleBackColor = true;
            this.ButtonHideWindow.Click += new System.EventHandler(this.ButtonHideWindow_Click);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAbout.Location = new System.Drawing.Point(6, 327);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(285, 23);
            this.ButtonAbout.TabIndex = 2;
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // buttonClearUsageData
            // 
            this.buttonClearUsageData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearUsageData.Location = new System.Drawing.Point(6, 356);
            this.buttonClearUsageData.Name = "buttonClearUsageData";
            this.buttonClearUsageData.Size = new System.Drawing.Size(285, 23);
            this.buttonClearUsageData.TabIndex = 1;
            this.buttonClearUsageData.Text = "Clear usage data";
            this.buttonClearUsageData.UseVisualStyleBackColor = true;
            this.buttonClearUsageData.Click += new System.EventHandler(this.buttonClearUsageData_Click);
            // 
            // ButtonDebugPrintAll
            // 
            this.ButtonDebugPrintAll.Location = new System.Drawing.Point(6, 6);
            this.ButtonDebugPrintAll.Name = "ButtonDebugPrintAll";
            this.ButtonDebugPrintAll.Size = new System.Drawing.Size(285, 23);
            this.ButtonDebugPrintAll.TabIndex = 0;
            this.ButtonDebugPrintAll.Text = "Print all entries (debug)";
            this.ButtonDebugPrintAll.UseVisualStyleBackColor = true;
            this.ButtonDebugPrintAll.Click += new System.EventHandler(this.ButtonDebugPrintAll_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "test";
            this.notifyIcon.BalloonTipTitle = "test";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Activity Monitor - running. Click to show window.";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your data is automatically saved, this exports data from a previous session.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.foreground_wnd_label);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.TabActLog.ResumeLayout(false);
            this.TabActLog.PerformLayout();
            this.TabSummary.ResumeLayout(false);
            this.TabSummary.PerformLayout();
            this.TabAnalytics.ResumeLayout(false);
            this.TabAnalytics.PerformLayout();
            this.TabSettings.ResumeLayout(false);
            this.TabSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foreground_wnd_label;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ListView ActListView;
        private System.Windows.Forms.ColumnHeader LastUsed;
        private System.Windows.Forms.ColumnHeader FirstUsed;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader NameColmn;
        private System.Windows.Forms.ColumnHeader ImagePath;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabActLog;
        private System.Windows.Forms.TabPage TabSummary;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.Button ButtonDebugPrintAll;
        private System.Windows.Forms.Label labelRuntime;
        private System.Windows.Forms.Label labelCurrentTaskSwitches;
        private System.Windows.Forms.Label labelCurrentRuntime;
        private System.Windows.Forms.Label labelTaskSwitches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TabAnalytics;
        private System.Windows.Forms.ListView AnalyticsLV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonRefreshAnalytics;
        private System.Windows.Forms.ColumnHeader ApplicationName;
        private System.Windows.Forms.ColumnHeader ApplicationFilePath;
        private System.Windows.Forms.ColumnHeader SwitchesTo;
        private System.Windows.Forms.ColumnHeader TotalUsageTime;
        private System.Windows.Forms.ColumnHeader TodayUsageTime;
        private System.Windows.Forms.Button buttonClearUsageData;
        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button ButtonHideWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLoadUsageData;
        private System.Windows.Forms.Label label3;
    }
}

