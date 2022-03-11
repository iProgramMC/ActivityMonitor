using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityMonitor
{
    public partial class MainForm : Form
    {
        public string version = "1.00";
        public List<Entry> entries = new List<Entry>();
        public DateTime startTime;
        public int taskSwitchesNow = 0;
        public MainForm()
        {
            InitializeComponent();
            Text = "Activity Monitor - Actually useful spyware for your computer (offline) - V"+version+" - Made by iProgramInCpp";
            LoadEntryDataFromSettings();
            startTime = DateTime.Now;
            TabControl.SelectedTab = TabSummary;
        }

        public bool IsWindowTheLatestEntry(int pid)
        {
            if (entries.Count == 0) return false;
            return entries[0].ProcID == pid;
        }

        void WriteEntryData(ref StringBuilder sb)
        {
            for (int i = 0; i < entries.Count; i++)
            {
                Entry e = entries[i];
                sb.Append($"new_entry_data|{e.FirstUsed}|{e.LastUsed}|{e.Name}|{e.ImagePath}|{-((int)Math.Abs(e.ProcID))}\n");//negative means that we won't use this PID anymore
            }
        }
        void SaveEntryDataToSettings()
        {
            StringBuilder sb = new StringBuilder(entries.Count * 100);

            WriteEntryData(ref sb);

            Properties.Settings.Default.EntryData = sb.ToString();
        }
        void LoadEntryDataFromSettings()
        {
            Random rng = new Random();
            string[] lines = Properties.Settings.Default.EntryData.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                AddNewEntryToList();
                string[] test = lines[i].Split('|');
                if (test.Length > 0)
                {
                    if (test[0] == "new_entry_data")
                    {
                        if (test.Length < 6)
                        {
                            Debug.WriteLine("Error with new_entry_data parms");
                            continue;
                        }
                        Entry e = new Entry();
                        e.FirstUsed = DateTime.Parse(test[1]);
                        e.LastUsed  = DateTime.Parse(test[2]);
                        e.Name = test[3];
                        e.ImagePath = test[4];
                        if (!int.TryParse(test[5], out e.ProcID))
                        {
                            Debug.WriteLine("Task switch with imagepath: " + e.ImagePath + " at index " + i.ToString() + " has bad PID, assigning random one");
                            e.ProcID = rng.Next(-200000, -1);
                        }
                        entries.Add(e);
                    }
                }
            }
            UpdateListViewItems();
        }
        void AddNewEntryToList()
        {
            ActListView.Items.Insert(0, new ListViewItem());
        }
        void UpdateListViewItems()
        {
            if (TabControl.SelectedTab != TabActLog) return;/*
            ActListView.Items.Clear();
            for (int i = 0; i < entries.Count; i++)
            {
                ActListView.Items.Add());
            }*/

            for (int i = 0; i < entries.Count; i++)
            {
                Entry e = entries[i];

                ListViewItem garbage = new ListViewItem(new string[] { e.LastUsed.ToString(), e.FirstUsed.ToString(), e.ProcID.ToString(), e.Name, e.ImagePath });

                bool needsUpdate = false;
                if (ActListView.Items[i].SubItems.Count >= 3)
                    needsUpdate = ActListView.Items[i].SubItems[3].Text != e.Name;
                else
                    needsUpdate = true;

                garbage.BackColor = e.ProcID < 0 ? Color.Beige : Color.White;

                if (needsUpdate)
                    ActListView.Items[i] = garbage;
            }
        }

        void CheckAndUpdateForegroundWindow()
        {
            //checks the foreground window every 100ms or so
            var fg_window = WinApi.GetForegroundWindow();
            StringBuilder title = new StringBuilder(256);
            WinApi.GetWindowText(fg_window, title, 256);
            //Debug.WriteLine(title.ToString());

            //get thread pid
            int lol;
            WinApi.GetWindowThreadProcessId(fg_window, out lol);
            if (lol == 0)
            {
                Debug.WriteLine("System process!?");
                return;
            }

            //don't bother with winapi, use builtin C# stuff
            Process p = Process.GetProcessById(lol);
            string filename;

            try
            {
                filename = p.MainModule.FileName;
            }
            catch
            {
                filename = "Unknown Image Path for Program: " + title.ToString();
            }

            //now add a new entry if the last one is invalid
            if (!IsWindowTheLatestEntry(lol))
            {
                if (entries.Count != 0) entries[0].LastUsed = DateTime.Now;
                //add a new entry
                entries.Insert(0, new Entry());
                entries[0].FirstUsed = DateTime.Now;
                AddNewEntryToList();
                UpdateListViewItems();
                taskSwitchesNow++;
            }
            //now update stuff like the imagepath in the new/previous entry
            entries[0].Name = title.ToString();
            if (entries[0].Name.Length == 0) entries[0].Name = "(no name)";
            entries[0].ImagePath = filename;
            entries[0].LastUsed = DateTime.Now;
            entries[0].ProcID = lol;
            UpdateListViewItems();

            foreground_wnd_label.Text = "Current foreground window: " + title;
        }

        string GetNicelyFormattedStringFromTimeSpan(TimeSpan span)
        {
            StringBuilder data = new StringBuilder(50);
            if (span.Days != 0)    data.Append(span.Days.ToString() + " day(s)");
            if (span.Hours != 0)   { if (data.Length != 0) data.Append(", "); data.Append(span.Hours.ToString() + " hour(s)");   }
            if (span.Minutes != 0) { if (data.Length != 0) data.Append(", "); data.Append(span.Minutes.ToString() + " min(s)"); }
            if (span.Seconds != 0) { if (data.Length != 0) data.Append(", "); data.Append(span.Seconds.ToString() + " sec(s)"); }
            if (data.Length == 0) data.Append("(None)");
            return data.ToString();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            CheckAndUpdateForegroundWindow();

            //update total runtime
            labelRuntime            .Text = "Total runtime: " + GetNicelyFormattedStringFromTimeSpan(Properties.Settings.Default.TotalRuntime + (DateTime.Now - startTime));
            labelCurrentRuntime     .Text = "Runtime in current session: " + GetNicelyFormattedStringFromTimeSpan(DateTime.Now - startTime);
            labelTaskSwitches       .Text = "Total task switches: " + entries.Count;
            labelCurrentTaskSwitches.Text = "Task switches in current session: " + taskSwitchesNow;
        }

        private void ButtonDebugPrintAll_Click(object sender, EventArgs eva)
        {
            Debug.WriteLine("Entry logging started.");
            for (int i = 0; i < entries.Count; i++)
            {
                Entry e = entries[i];
                Debug.WriteLine($"[Entry] FirstUsed: {e.FirstUsed} LastUsed: {e.LastUsed} PID: {e.ProcID} Name: \"{e.Name}\" ImagePath: \"{e.ImagePath}\"");
            }
            Debug.WriteLine("Entry logging ended.");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (entries.Count > 0)
                entries[0].LastUsed = DateTime.Now;
            SaveEntryDataToSettings();
            Properties.Settings.Default.TotalRuntime += (DateTime.Now - startTime);
            Properties.Settings.Default.TotalTaskSwitches += taskSwitchesNow;
            Properties.Settings.Default.Save();
        }

        void RefreshAnalyticsListView()
        {
            AnalyticsLV.Items.Clear();

            Dictionary<string, AppAnalytic> appAnalytics = new Dictionary<string, AppAnalytic>();//uses app imagepath to index

            DateTime today = DateTime.Today;

            for (int i = entries.Count-1; i >= 0; i--)
            {
                AppAnalytic analytic;
                if (!appAnalytics.ContainsKey(entries[i].ImagePath))
                {
                    analytic = new AppAnalytic();
                    appAnalytics[entries[i].ImagePath] = analytic;
                }
                else analytic = appAnalytics[entries[i].ImagePath];

                analytic.NumOfSwitchesToTask++;
                analytic.Name = entries[i].Name;
                analytic.ImagePath = entries[i].ImagePath;

                TimeSpan time = entries[i].LastUsed - entries[i].FirstUsed;

                analytic.TotalTimeUsed += time;
                if (entries[i].FirstUsed < today)
                {
                    time = entries[i].LastUsed - today;
                }
                analytic.TotalTimeUsedToday += time;
            }

            //add the items to the table
            foreach (var kvp in appAnalytics)
            {
                AnalyticsLV.Items.Add(new ListViewItem(new string[] {
                    kvp.Value.Name, kvp.Key, kvp.Value.NumOfSwitchesToTask.ToString(),
                    GetNicelyFormattedStringFromTimeSpan(kvp.Value.TotalTimeUsed),
                    GetNicelyFormattedStringFromTimeSpan(kvp.Value.TotalTimeUsedToday)
                }));
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == TabAnalytics)
            {
                RefreshAnalyticsListView();
            }
            if (TabControl.SelectedTab == TabActLog)
            {
                UpdateListViewItems();
            }
        }

        private void ButtonRefreshAnalytics_Click(object sender, EventArgs e)
        {
            RefreshAnalyticsListView();
        }

        private void buttonClearUsageData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clearing usage data means removing it from disk and never seeing it again.\r\n\r\nAre you absolutely sure you want to do this?", 
                                "Activity Monitor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Properties.Settings.Default.TotalRuntime = TimeSpan.Zero;
                Properties.Settings.Default.TotalTaskSwitches = 0;
                Properties.Settings.Default.EntryData = "";
                Properties.Settings.Default.Save();

                entries.Clear();
                AnalyticsLV.Items.Clear();
                ActListView.Items.Clear();
                startTime = DateTime.Now;
            }
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Activity Monitor (C) 2021 iProgramInCpp\r\n\r\nVersion "+version,
                "Activity Monitor",
                MessageBoxButtons.OK);
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ButtonHideWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSaveUsageData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter="Usage data (*.amu)|*.amu"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder data = new StringBuilder(entries.Count * 120);
                data.Append($"total_time_used|{Properties.Settings.Default.TotalRuntime + (DateTime.Now - startTime)}\n");
                data.Append($"total_task_switches|{Properties.Settings.Default.TotalTaskSwitches + taskSwitchesNow}\n");
                WriteEntryData(ref data);
                File.WriteAllText(saveFileDialog.FileName, data.ToString());
            }
        }

        private void buttonLoadUsageData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO!");
        }
    }
    public class AppAnalytic
    {
        public string Name, ImagePath;
        public TimeSpan TotalTimeUsed;
        public int NumOfSwitchesToTask;
        public TimeSpan TotalTimeUsedToday;
    }
    public class Entry
    {
        public DateTime LastUsed, FirstUsed;
        public string Name, ImagePath;
        public Icon Icon;
        public int ProcID;
    }
    public static class WinApi
    {
        [DllImport("user32.dll")] public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet=CharSet.Auto)] public static extern IntPtr GetWindowText(IntPtr hWnd, StringBuilder title, int size);
        [DllImport("user32.dll")] public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
        [DllImport("kernel32.dll")] public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);
        [DllImport("kernel32.dll")] public static extern uint CloseHandle(IntPtr handlePtr);
        [DllImport("kernel32.dll")] public static extern uint GetLastError();
        [DllImport("kernel32.dll")] public static extern uint GetModuleFileName(IntPtr hModule, StringBuilder fileName, int size);
    }
}
