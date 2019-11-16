namespace Birthday_Calendar
{
    partial class FormAddReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddReminder));
            this.gp_Date = new System.Windows.Forms.GroupBox();
            this.btn_Today = new System.Windows.Forms.Button();
            this.chb_SkipYear = new System.Windows.Forms.CheckBox();
            this.lb_SkipYear = new System.Windows.Forms.Label();
            this.tb_Year = new System.Windows.Forms.TextBox();
            this.cb_Month = new System.Windows.Forms.ComboBox();
            this.tb_Day = new System.Windows.Forms.TextBox();
            this.lb_Year = new System.Windows.Forms.Label();
            this.lb_Month = new System.Windows.Forms.Label();
            this.lb_Day = new System.Windows.Forms.Label();
            this.gb_Event = new System.Windows.Forms.GroupBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Type = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.gp_Date.SuspendLayout();
            this.gb_Event.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_Date
            // 
            this.gp_Date.Controls.Add(this.btn_Today);
            this.gp_Date.Controls.Add(this.chb_SkipYear);
            this.gp_Date.Controls.Add(this.lb_SkipYear);
            this.gp_Date.Controls.Add(this.tb_Year);
            this.gp_Date.Controls.Add(this.cb_Month);
            this.gp_Date.Controls.Add(this.tb_Day);
            this.gp_Date.Controls.Add(this.lb_Year);
            this.gp_Date.Controls.Add(this.lb_Month);
            this.gp_Date.Controls.Add(this.lb_Day);
            this.gp_Date.Location = new System.Drawing.Point(13, 13);
            this.gp_Date.Margin = new System.Windows.Forms.Padding(20);
            this.gp_Date.Name = "gp_Date";
            this.gp_Date.Size = new System.Drawing.Size(317, 131);
            this.gp_Date.TabIndex = 0;
            this.gp_Date.TabStop = false;
            this.gp_Date.Text = "Date";
            // 
            // btn_Today
            // 
            this.btn_Today.Location = new System.Drawing.Point(223, 26);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(75, 31);
            this.btn_Today.TabIndex = 8;
            this.btn_Today.Text = "Today";
            this.btn_Today.UseVisualStyleBackColor = true;
            this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
            // 
            // chb_SkipYear
            // 
            this.chb_SkipYear.AutoSize = true;
            this.chb_SkipYear.Location = new System.Drawing.Point(281, 100);
            this.chb_SkipYear.Name = "chb_SkipYear";
            this.chb_SkipYear.Size = new System.Drawing.Size(18, 17);
            this.chb_SkipYear.TabIndex = 7;
            this.chb_SkipYear.UseVisualStyleBackColor = true;
            this.chb_SkipYear.CheckedChanged += new System.EventHandler(this.chb_SkipYear_CheckedChanged);
            // 
            // lb_SkipYear
            // 
            this.lb_SkipYear.AutoSize = true;
            this.lb_SkipYear.Location = new System.Drawing.Point(208, 100);
            this.lb_SkipYear.Name = "lb_SkipYear";
            this.lb_SkipYear.Size = new System.Drawing.Size(67, 17);
            this.lb_SkipYear.TabIndex = 6;
            this.lb_SkipYear.Text = "Skip year";
            // 
            // tb_Year
            // 
            this.tb_Year.Location = new System.Drawing.Point(63, 97);
            this.tb_Year.Name = "tb_Year";
            this.tb_Year.Size = new System.Drawing.Size(50, 22);
            this.tb_Year.TabIndex = 5;
            // 
            // cb_Month
            // 
            this.cb_Month.DropDownWidth = 100;
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.Location = new System.Drawing.Point(63, 63);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.Size = new System.Drawing.Size(98, 24);
            this.cb_Month.TabIndex = 4;
            this.cb_Month.SelectedIndexChanged += new System.EventHandler(this.cb_Month_SelectedIndexChanged);
            // 
            // tb_Day
            // 
            this.tb_Day.Location = new System.Drawing.Point(63, 33);
            this.tb_Day.Name = "tb_Day";
            this.tb_Day.Size = new System.Drawing.Size(30, 22);
            this.tb_Day.TabIndex = 3;
            this.tb_Day.TextChanged += new System.EventHandler(this.tb_Day_TextChanged);
            // 
            // lb_Year
            // 
            this.lb_Year.AutoSize = true;
            this.lb_Year.Location = new System.Drawing.Point(7, 100);
            this.lb_Year.Name = "lb_Year";
            this.lb_Year.Size = new System.Drawing.Size(38, 17);
            this.lb_Year.TabIndex = 2;
            this.lb_Year.Text = "Year";
            // 
            // lb_Month
            // 
            this.lb_Month.AutoSize = true;
            this.lb_Month.Location = new System.Drawing.Point(7, 63);
            this.lb_Month.Name = "lb_Month";
            this.lb_Month.Size = new System.Drawing.Size(47, 17);
            this.lb_Month.TabIndex = 1;
            this.lb_Month.Text = "Month";
            // 
            // lb_Day
            // 
            this.lb_Day.AutoSize = true;
            this.lb_Day.Location = new System.Drawing.Point(7, 33);
            this.lb_Day.Name = "lb_Day";
            this.lb_Day.Size = new System.Drawing.Size(33, 17);
            this.lb_Day.TabIndex = 0;
            this.lb_Day.Text = "Day";
            // 
            // gb_Event
            // 
            this.gb_Event.Controls.Add(this.tb_Name);
            this.gb_Event.Controls.Add(this.lb_Type);
            this.gb_Event.Controls.Add(this.lb_Name);
            this.gb_Event.Controls.Add(this.cb_Type);
            this.gb_Event.Location = new System.Drawing.Point(13, 163);
            this.gb_Event.Margin = new System.Windows.Forms.Padding(20);
            this.gb_Event.Name = "gb_Event";
            this.gb_Event.Size = new System.Drawing.Size(317, 112);
            this.gb_Event.TabIndex = 1;
            this.gb_Event.TabStop = false;
            this.gb_Event.Text = "Event";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(63, 72);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(236, 22);
            this.tb_Name.TabIndex = 2;
            // 
            // lb_Type
            // 
            this.lb_Type.AutoSize = true;
            this.lb_Type.Location = new System.Drawing.Point(7, 35);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(40, 17);
            this.lb_Type.TabIndex = 1;
            this.lb_Type.Text = "Type";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(7, 75);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(45, 17);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Name";
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(63, 32);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(237, 24);
            this.cb_Type.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.Location = new System.Drawing.Point(13, 303);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(20);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 31);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(130, 303);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(20);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 31);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(255, 303);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(20);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FormAddReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(342, 348);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Event);
            this.Controls.Add(this.gp_Date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birthday Calendar";
            this.gp_Date.ResumeLayout(false);
            this.gp_Date.PerformLayout();
            this.gb_Event.ResumeLayout(false);
            this.gb_Event.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_Date;
        private System.Windows.Forms.Button btn_Today;
        private System.Windows.Forms.CheckBox chb_SkipYear;
        private System.Windows.Forms.Label lb_SkipYear;
        private System.Windows.Forms.TextBox tb_Year;
        private System.Windows.Forms.ComboBox cb_Month;
        private System.Windows.Forms.TextBox tb_Day;
        private System.Windows.Forms.Label lb_Year;
        private System.Windows.Forms.Label lb_Month;
        private System.Windows.Forms.Label lb_Day;
        private System.Windows.Forms.GroupBox gb_Event;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
    }
}