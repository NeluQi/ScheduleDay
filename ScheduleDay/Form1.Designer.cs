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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainGrid = new MetroFramework.Controls.MetroGrid();
            this.ContextMenuPCMTabl = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.SetupButton = new MetroFramework.Controls.MetroButton();
            this.важноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.ContextMenuPCMTabl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MainGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.MainGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.MainGrid.EnableHeadersVisualStyles = false;
            this.MainGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MainGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainGrid.Location = new System.Drawing.Point(5, 63);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MainGrid.RowHeadersWidth = 40;
            this.MainGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = null;
            this.MainGrid.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(946, 577);
            this.MainGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.MainGrid.TabIndex = 1;
            this.MainGrid.UseCustomForeColor = true;
            this.MainGrid.UseStyleColors = true;
            this.MainGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellEndEdit);
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
            this.SetupButton.Location = new System.Drawing.Point(866, 34);
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
            this.важноToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.важноToolStripMenuItem.Text = "Красный";
            this.важноToolStripMenuItem.Click += new System.EventHandler(this.важноToolStripMenuItem_Click);
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.желтыйToolStripMenuItem.Text = "Желтый";
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            // 
            // серыйToolStripMenuItem
            // 
            this.серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            this.серыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.серыйToolStripMenuItem.Text = "Серый";
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
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.Time.DefaultCellStyle = dataGridViewCellStyle3;
            this.Time.Frozen = true;
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.Width = 90;
            // 
            // Day1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Day1.DefaultCellStyle = dataGridViewCellStyle4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(956, 651);
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
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ContextMenuPCMTabl.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

