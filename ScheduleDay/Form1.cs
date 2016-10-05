using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ScheduleDay
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            loadTo(MainGrid);
            EventList.Clear();
            for (int i = 0; i < MainGrid.RowCount;)
            {
                ObjTimes Temp = new ObjTimes();
                Temp.numberRow = i;
                if (MainGrid.Rows[i].Cells[0].Value == null) { Temp.time = null; }
                else { Temp.time = MainGrid.Rows[i].Cells[0].Value.ToString(); }
                try { EventList.Add(Temp); }
                catch { }
                i++;
            }
            this.Width = 972;

            TreyIcon.Visible = false;
            this.TreyIcon.MouseDoubleClick += new MouseEventHandler(TreyIcon_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);

            AutoRun.Checked = Properties.Settings.Default.AutoRun;
            Notifi.Checked = Properties.Settings.Default.Notifi;
        }
        const string name = "ScheduleDay";
        public static List<ObjTimes> EventList = new List<ObjTimes>();

        public class ObjTimes
        {
            public string time { get; set; }
            public int numberRow { get; set; }
        }

        /// Print
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(MainGrid.Size.Width + 10, MainGrid.Size.Height + 10);
            MainGrid.DrawToBitmap(bmp, MainGrid.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        public static void saveTo(DataGridView dr)
        {
            try
            {
                string file = "data.bin";
                using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
                {
                    bw.Write(dr.Columns.Count);
                    bw.Write(dr.Rows.Count);
                    foreach (DataGridViewRow dgvR in dr.Rows)
                    {
                        for (int j = 0; j < dr.Columns.Count; ++j)
                        {
                            object val = dgvR.Cells[j].Value;
                            if (val == null)
                            {
                                bw.Write(false);
                                bw.Write(false);
                            }
                            else
                            {
                                bw.Write(true);
                                bw.Write(val.ToString());
                            }
                        }
                    }
                }
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        public static void loadTo(DataGridView dr)
        {
            try
            {
                dr.Rows.Clear();
                string file = "data.bin";
                using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
                {
                    int n = bw.ReadInt32();
                    int m = bw.ReadInt32();
                    for (int i = 0; i < m; ++i)
                    {
                        dr.Rows.Add();
                        for (int j = 0; j < n; ++j)
                        {
                            if (bw.ReadBoolean())
                            {
                                dr.Rows[i].Cells[j].Value = bw.ReadString();
                            }
                            else bw.ReadBoolean();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void MainGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            saveTo(MainGrid);
            EventList.Clear();
            for (int i = 0; i <= MainGrid.RowCount;)
            {
                ObjTimes Temp = new ObjTimes();
                Temp.numberRow = i;

                try {
                    if (MainGrid.Rows[i].Cells[0].Value.ToString() == "") { Temp.time = null; }
                    else { Temp.time = MainGrid.Rows[i].Cells[0].Value.ToString(); }


                    EventList.Add(Temp); }
                catch { }
                i++;
            }
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            if (this.Width != 1262)
            this.Width = 1262;
            else
                this.Width = 972;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGrid.CurrentCell.Value = "";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void ToEXCELButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < MainGrid.Rows.Count; i++)
            {
                for (int j = 0; j < MainGrid.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = MainGrid.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        public int Day = 0;
        public DateTime dt = new DateTime();

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = System.DateTime.Today;
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Day = 1;
                    break;

                case DayOfWeek.Tuesday:
                    Day = 2;
                    break;

                case DayOfWeek.Wednesday:
                    Day = 3;
                    break;

                case DayOfWeek.Thursday:
                    Day = 4;
                    break;

                case DayOfWeek.Friday:
                    Day = 5;
                    break;

                case DayOfWeek.Saturday:
                    Day = 6;
                    break;

                case DayOfWeek.Sunday:
                    Day = 7;
                    break;
            }
            System.Windows.Forms.Timer timerEvent = new System.Windows.Forms.Timer();
            timerEvent.Enabled = true;
            timerEvent.Interval = 55000;
            timerEvent.Tick += tmrShow_Tick;
        }



        private void tmrShow_Tick(object sender, EventArgs e)
        {
            dt = System.DateTime.Today;
            for (int i = 0; i <= EventList.Count; i++)
            {
                try
                {
                    if (EventList[i].time == System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString())
                    {
                        NotificShow(5, MainGrid.Rows[EventList[i].numberRow].Cells[Day].Value.ToString());
                    }
                }
                catch { }
            }
        }

        private void TreyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreyIcon.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void NotificShow(int secondClose, string text) // Метод для вызова уведомления.
        {
            ShowN notific = new ShowN(secondClose, text);
            notific.Visible = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                TreyIcon.Visible = true;
            }
        }

        private void Notifi_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Notifi = Notifi.Checked;
            Properties.Settings.Default.Save();
        }
    private void AutoRun_CheckedChanged(object sender, EventArgs e)
        {
           Properties.Settings.Default.AutoRun = AutoRun.Checked;
           Properties.Settings.Default.Save();
           if(AutoRun.Checked)
                SetAutorunValue(true);
           else
                SetAutorunValue(false);
        }
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath);
                else
                    reg.DeleteValue(name);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void LoadSC_Click(object sender, EventArgs e)
        {
            try
            {
                EventList.Clear();
                for (int i = 0; i < MainGrid.RowCount;)
                {
                    ObjTimes Temp = new ObjTimes();
                    Temp.numberRow = i;
                    if (MainGrid.Rows[i].Cells[0].Value == null) { Temp.time = null; }
                    else { Temp.time = MainGrid.Rows[i].Cells[0].Value.ToString(); }
                    try { EventList.Add(Temp); }
                    catch { }
                    i++;
                }
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.ShowDialog();
                MainGrid.Rows.Clear();
                string file = OFD.FileName;
                using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
                {
                    int n = bw.ReadInt32();
                    int m = bw.ReadInt32();
                    for (int i = 0; i < m; ++i)
                    {
                        MainGrid.Rows.Add();
                        for (int j = 0; j < n; ++j)
                        {
                            if (bw.ReadBoolean())
                            {
                                MainGrid.Rows[i].Cells[j].Value = bw.ReadString();
                            }
                            else bw.ReadBoolean();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveTo(MainGrid);
        }
    }
}