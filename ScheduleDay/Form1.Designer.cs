namespace ScheduleDay
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainGrid = new MetroFramework.Controls.MetroGrid();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuPCMTabl = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.SetupButton = new MetroFramework.Controls.MetroButton();
            this.важноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintButton = new MetroFramework.Controls.MetroButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ToEXCELButton = new MetroFramework.Controls.MetroButton();
            this.TreyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.AutoRun = new MetroFramework.Controls.MetroCheckBox();
            this.Notifi = new MetroFramework.Controls.MetroCheckBox();
            this.LoadSC = new MetroFramework.Controls.MetroButton();
            this.SettLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.ContextMenuPCMTabl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MainGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.MainGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.MainGrid.ColumnHeadersHeight = 40;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Day1,
            this.Day2,
            this.Day3,
            this.Day4,
            this.Day5,
            this.Day6,
            this.Day7});
            this.MainGrid.ContextMenuStrip = this.ContextMenuPCMTabl;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.MainGrid.EnableHeadersVisualStyles = false;
            this.MainGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MainGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainGrid.Location = new System.Drawing.Point(5, 63);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.MainGrid.RowHeadersWidth = 40;
            this.MainGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.NullValue = null;
            this.MainGrid.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(968, 577);
            this.MainGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.MainGrid.TabIndex = 1;
            this.MainGrid.UseCustomForeColor = true;
            this.MainGrid.UseStyleColors = true;
            this.MainGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellEndEdit);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            this.Time.DefaultCellStyle = dataGridViewCellStyle10;
            this.Time.Frozen = true;
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.Width = 90;
            // 
            // Day1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Day1.DefaultCellStyle = dataGridViewCellStyle11;
            this.Day1.HeaderText = "Понедельник";
            this.Day1.Name = "Day1";
            this.Day1.Width = 152;
            // 
            // Day2
            // 
            this.Day2.HeaderText = "Вторник";
            this.Day2.Name = "Day2";
            this.Day2.Width = 107;
            // 
            // Day3
            // 
            this.Day3.HeaderText = "Среда";
            this.Day3.Name = "Day3";
            this.Day3.Width = 88;
            // 
            // Day4
            // 
            this.Day4.HeaderText = "Четверг";
            this.Day4.Name = "Day4";
            this.Day4.Width = 104;
            // 
            // Day5
            // 
            this.Day5.HeaderText = "Пятница";
            this.Day5.Name = "Day5";
            this.Day5.Width = 110;
            // 
            // Day6
            // 
            this.Day6.HeaderText = "Суббота";
            this.Day6.Name = "Day6";
            this.Day6.Width = 107;
            // 
            // Day7
            // 
            this.Day7.HeaderText = "Воскресенье";
            this.Day7.Name = "Day7";
            this.Day7.Width = 146;
            // 
            // ContextMenuPCMTabl
            // 
            this.ContextMenuPCMTabl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.ContextMenuPCMTabl.Name = "ContextMenuPCMTabl";
            this.ContextMenuPCMTabl.Size = new System.Drawing.Size(119, 26);
            this.ContextMenuPCMTabl.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // SetupButton
            // 
            this.SetupButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SetupButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.SetupButton.Location = new System.Drawing.Point(865, 34);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(85, 23);
            this.SetupButton.TabIndex = 2;
            this.SetupButton.Text = "Настройки";
            this.SetupButton.UseSelectable = true;
            this.SetupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // важноToolStripMenuItem
            // 
            this.важноToolStripMenuItem.Name = "важноToolStripMenuItem";
            this.важноToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // серыйToolStripMenuItem
            // 
            this.серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            this.серыйToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // пToolStripMenuItem
            // 
            this.пToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.важноToolStripMenuItem,
            this.желтыйToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.серыйToolStripMenuItem});
            this.пToolStripMenuItem.Name = "пToolStripMenuItem";
            this.пToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.пToolStripMenuItem.Text = "Назначить приоритет";
            // 
            // PrintButton
            // 
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrintButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.PrintButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.PrintButton.Location = new System.Drawing.Point(1174, 210);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 3;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseSelectable = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ToEXCELButton
            // 
            this.ToEXCELButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ToEXCELButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ToEXCELButton.Location = new System.Drawing.Point(1007, 210);
            this.ToEXCELButton.Name = "ToEXCELButton";
            this.ToEXCELButton.Size = new System.Drawing.Size(124, 23);
            this.ToEXCELButton.TabIndex = 4;
            this.ToEXCELButton.Text = "Открыть в Excel";
            this.ToEXCELButton.UseSelectable = true;
            this.ToEXCELButton.Click += new System.EventHandler(this.ToEXCELButton_Click);
            // 
            // TreyIcon
            // 
            this.TreyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TreyIcon.Icon")));
            this.TreyIcon.Text = "notifyIcon1";
            this.TreyIcon.Visible = true;
            this.TreyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TreyIcon_MouseDoubleClick);
            // 
            // AutoRun
            // 
            this.AutoRun.AutoSize = true;
            this.AutoRun.Location = new System.Drawing.Point(1007, 162);
            this.AutoRun.Name = "AutoRun";
            this.AutoRun.Size = new System.Drawing.Size(157, 15);
            this.AutoRun.TabIndex = 5;
            this.AutoRun.Text = "Добавить в автозагрузку";
            this.AutoRun.UseSelectable = true;
            this.AutoRun.CheckedChanged += new System.EventHandler(this.AutoRun_CheckedChanged);
            // 
            // Notifi
            // 
            this.Notifi.AutoSize = true;
            this.Notifi.Location = new System.Drawing.Point(1007, 115);
            this.Notifi.Name = "Notifi";
            this.Notifi.Size = new System.Drawing.Size(154, 15);
            this.Notifi.TabIndex = 6;
            this.Notifi.Text = "Включить уведомления";
            this.Notifi.UseSelectable = true;
            this.Notifi.CheckedChanged += new System.EventHandler(this.Notifi_CheckedChanged);
            // 
            // LoadSC
            // 
            this.LoadSC.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.LoadSC.Location = new System.Drawing.Point(1007, 249);
            this.LoadSC.Name = "LoadSC";
            this.LoadSC.Size = new System.Drawing.Size(143, 23);
            this.LoadSC.TabIndex = 8;
            this.LoadSC.Text = "Загрузить расписание";
            this.LoadSC.UseSelectable = true;
            this.LoadSC.Click += new System.EventHandler(this.LoadSC_Click);
            // 
            // SettLabel
            // 
            this.SettLabel.AutoSize = true;
            this.SettLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SettLabel.Location = new System.Drawing.Point(1082, 60);
            this.SettLabel.Name = "SettLabel";
            this.SettLabel.Size = new System.Drawing.Size(96, 25);
            this.SettLabel.TabIndex = 10;
            this.SettLabel.Text = "Настройки";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1156, 249);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "(Файл data.bin)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(972, 651);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SettLabel);
            this.Controls.Add(this.LoadSC);
            this.Controls.Add(this.Notifi);
            this.Controls.Add(this.AutoRun);
            this.Controls.Add(this.ToEXCELButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.SetupButton);
            this.Controls.Add(this.MainGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Расписание ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ContextMenuPCMTabl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid MainGrid;
        private System.Drawing.Printing.PrintDocument printDocument;
        private MetroFramework.Controls.MetroButton SetupButton;
        private MetroFramework.Controls.MetroContextMenu ContextMenuPCMTabl;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem важноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day7;
        private MetroFramework.Controls.MetroButton PrintButton;
        private System.Windows.Forms.PrintDialog printDialog1;
        private MetroFramework.Controls.MetroButton ToEXCELButton;
        private System.Windows.Forms.NotifyIcon TreyIcon;
        private MetroFramework.Controls.MetroCheckBox AutoRun;
        private MetroFramework.Controls.MetroCheckBox Notifi;
        private MetroFramework.Controls.MetroButton LoadSC;
        private MetroFramework.Controls.MetroLabel SettLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

