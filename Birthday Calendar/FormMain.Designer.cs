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
            this.btn_New = new System.Windows.Forms.Button();
            this.dgv_ReminderTable = new System.Windows.Forms.DataGridView();
            this.mc_Calendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReminderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.Location = new System.Drawing.Point(229, 641);
            this.btn_New.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(125, 31);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // dgv_ReminderTable
            // 
            this.dgv_ReminderTable.AllowUserToAddRows = false;
            this.dgv_ReminderTable.AllowUserToOrderColumns = true;
            this.dgv_ReminderTable.AllowUserToResizeColumns = false;
            this.dgv_ReminderTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ReminderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ReminderTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ReminderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReminderTable.EnableHeadersVisualStyles = false;
            this.dgv_ReminderTable.Location = new System.Drawing.Point(11, 224);
            this.dgv_ReminderTable.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.dgv_ReminderTable.Name = "dgv_ReminderTable";
            this.dgv_ReminderTable.ReadOnly = true;
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
            this.mc_Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_Calendar_DateChanged);
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
            this.Controls.Add(this.btn_New);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birthday Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReminderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.MonthCalendar mc_Calendar;
        public System.Windows.Forms.DataGridView dgv_ReminderTable;
    }
}

