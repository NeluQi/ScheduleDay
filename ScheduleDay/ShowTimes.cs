using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDay
{
    public partial class ShowN : Form
    {
        Point pt = Screen.PrimaryScreen.WorkingArea.Location;
        private int _secondClose = 0;
        internal int SecondClose
        {
            get { return _secondClose; }
            set { _secondClose = value; }
        }
        public ShowN(int secondToClose, string text)
        {
            InitializeComponent();
            SecondClose = secondToClose;
            InfoLabel.Text = text;
            this.StartPosition = FormStartPosition.Manual;
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            pt.Offset(-this.Width, -this.Height);
            this.Location = pt;
            SystemSounds.Beep.Play();
            this.Location = new Point(this.Location.X, this.Location.Y + this.Height);
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < this.Height; i++)
                {
                    if (this.IsHandleCreated)
                    {
                        this.Invoke((Action)(() =>
                        {
                            this.Location = new Point(this.Location.X, this.Location.Y - 1);
                        }));
                    }
                    if (this.Location == pt) break;
                    Thread.Sleep(5);
                }
            });
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(_secondClose * 1000);
                this.Invoke((Action)(() =>
                {
                    ((IDisposable)this).Dispose();
                }));
            });
        }
    }
}
