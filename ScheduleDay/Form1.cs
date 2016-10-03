using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using System.IO;

namespace ScheduleDay
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            loadTo(MainGrid);

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
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
       
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGrid.CurrentCell.Value = "";
        }

        private void важноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells[MainGrid.CurrentCell.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
        }
    }
}
