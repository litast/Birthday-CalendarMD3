namespace Birthday_Calendar
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn_NewReminder = new System.Windows.Forms.Button();
            this.dgv_ReminderTable = new System.Windows.Forms.DataGridView();
            this.mc_Calendar = new System.Windows.Forms.MonthCalendar();
            this.ht_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ht_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ht_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ht_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ht_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReminderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NewReminder
            // 
            this.btn_NewReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NewReminder.Location = new System.Drawing.Point(229, 641);
            this.btn_NewReminder.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.btn_NewReminder.Name = "btn_NewReminder";
            this.btn_NewReminder.Size = new System.Drawing.Size(125, 31);
            this.btn_NewReminder.TabIndex = 1;
            this.btn_NewReminder.Text = "New reminder";
            this.btn_NewReminder.UseVisualStyleBackColor = true;
            this.btn_NewReminder.Click += new System.EventHandler(this.Btn_NewReminder_Click);
            // 
            // dgv_ReminderTable
            // 
            this.dgv_ReminderTable.AllowUserToAddRows = false;
            this.dgv_ReminderTable.AllowUserToDeleteRows = false;
            this.dgv_ReminderTable.AllowUserToOrderColumns = true;
            this.dgv_ReminderTable.AllowUserToResizeColumns = false;
            this.dgv_ReminderTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ReminderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ReminderTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ReminderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReminderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ht_Date,
            this.ht_Month,
            this.ht_Year,
            this.ht_Type,
            this.ht_Name});
            this.dgv_ReminderTable.EnableHeadersVisualStyles = false;
            this.dgv_ReminderTable.Location = new System.Drawing.Point(11, 224);
            this.dgv_ReminderTable.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.dgv_ReminderTable.Name = "dgv_ReminderTable";
            this.dgv_ReminderTable.RowHeadersWidth = 51;
            this.dgv_ReminderTable.RowTemplate.Height = 24;
            this.dgv_ReminderTable.ShowEditingIcon = false;
            this.dgv_ReminderTable.Size = new System.Drawing.Size(560, 400);
            this.dgv_ReminderTable.TabIndex = 2;
            this.dgv_ReminderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // mc_Calendar
            // 
            this.mc_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mc_Calendar.Location = new System.Drawing.Point(80, 9);
            this.mc_Calendar.Margin = new System.Windows.Forms.Padding(20);
            this.mc_Calendar.Name = "mc_Calendar";
            this.mc_Calendar.TabIndex = 3;
            // 
            // ht_Date
            // 
            this.ht_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ht_Date.HeaderText = "Date";
            this.ht_Date.MaxInputLength = 2;
            this.ht_Date.MinimumWidth = 6;
            this.ht_Date.Name = "ht_Date";
            this.ht_Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ht_Date.Width = 67;
            // 
            // ht_Month
            // 
            this.ht_Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ht_Month.HeaderText = "Month";
            this.ht_Month.MaxInputLength = 3;
            this.ht_Month.MinimumWidth = 6;
            this.ht_Month.Name = "ht_Month";
            this.ht_Month.Width = 76;
            // 
            // ht_Year
            // 
            this.ht_Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ht_Year.HeaderText = "Year";
            this.ht_Year.MaxInputLength = 4;
            this.ht_Year.MinimumWidth = 6;
            this.ht_Year.Name = "ht_Year";
            this.ht_Year.Width = 67;
            // 
            // ht_Type
            // 
            this.ht_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ht_Type.HeaderText = "Type";
            this.ht_Type.MaxInputLength = 2;
            this.ht_Type.MinimumWidth = 6;
            this.ht_Type.Name = "ht_Type";
            this.ht_Type.Width = 69;
            // 
            // ht_Name
            // 
            this.ht_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ht_Name.HeaderText = "Name";
            this.ht_Name.MaxInputLength = 100;
            this.ht_Name.MinimumWidth = 6;
            this.ht_Name.Name = "ht_Name";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(581, 695);
            this.Controls.Add(this.mc_Calendar);
            this.Controls.Add(this.dgv_ReminderTable);
            this.Controls.Add(this.btn_NewReminder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Birthday Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReminderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_NewReminder;
        private System.Windows.Forms.DataGridView dgv_ReminderTable;
        private System.Windows.Forms.MonthCalendar mc_Calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht_Name;
    }
}

