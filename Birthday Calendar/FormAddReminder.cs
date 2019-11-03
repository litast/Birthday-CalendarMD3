using System;
using System.Globalization;
using System.Windows.Forms;

namespace Birthday_Calendar
{
    public partial class FormAddReminder : Form
    {

        public FormAddReminder()
        {
            InitializeComponent();

            // Call Form2_Load event if relevant event data are passed
            if (MyEvent.day != 0) { 
                Load += new EventHandler(Form2_Load);
            }

            // Load combo-box 'Month' with defined values from MonthEnums
            foreach (int value in Enum.GetValues(typeof(MonthEnums)))
            {
                cb_Month.Items.Add(MyEvent.GetMonthName((MonthEnums)value));
            }

            // Load combo-box 'Type' with defined values from TypeEnums
            foreach (int value in Enum.GetValues(typeof(TypeEnums)))
            {
                cb_Type.Items.Add(MyEvent.GetType((TypeEnums)value));
            }
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            tb_Day.Text = MyEvent.day.ToString();
            cb_Month.SelectedIndex = (int)MyEvent.month;
            if (MyEvent.year == 0000)
            {
                chb_SkipYear.Checked = true;
            }
            else
            {
                tb_Year.Text = MyEvent.year.ToString();
            }
            cb_Type.SelectedIndex = (int)MyEvent.type;
            tb_Name.Text = MyEvent.name.ToString();

            btn_Delete.Enabled = true;
        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btn_Delete_Click(object sender, System.EventArgs e)
        {
            
        }

        private void btn_Today_Click(object sender, System.EventArgs e)
        {
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            String day = datevalue.Day.ToString();
            String month = DateTimeFormatInfo.CurrentInfo.GetMonthName(datevalue.Month);
            String year = datevalue.Year.ToString();
            tb_Day.Text = day;
            cb_Month.Text = month;
            tb_Year.Text = year;
        }

        private void tb_Date_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void cb_Month_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void chb_SkipYear_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chb_SkipYear.Checked == true)
            {
                tb_Year.Enabled = false;
            }
            else
            {
                tb_Year.Enabled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}