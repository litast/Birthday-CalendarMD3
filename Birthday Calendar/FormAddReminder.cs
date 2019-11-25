using System;
using System.Globalization;
using System.Windows.Forms;

namespace Birthday_Calendar
{
    public partial class FormAddReminder : Form
    {

        private readonly FormMain f1; // This will hold the parent until FormAddReminder is disposed

        public FormAddReminder(FormMain f2)
        {
            InitializeComponent();
            f1 = f2; // assign FormMain instance to a field

            // Call Form2_Load event if relevant event data are passed
            if (f1.buttonNewWasClicked == true)
            {

                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
            }
            else if (MyEvent.day != 0)
            {
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
                cb_Type.Items.Add(MyEvent.GetTypeName((TypeEnums)value));
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
            int selr = FormMain.selected_row;
            f1.DataTable_DeleteRecord();
            Dispose();

            /*
            var arrayUpdated = new string[rowc, colc];
            for (int i = 0; i < rowc; i++)
            {
                if (i != selr)
                {
                    for (int n = 0; n < colc; n++)
                    {
                        arrayUpdated[i, n] = FormMain.mydataarray[i, n];
                        Console.Write("rinda: " + i);
                        //Console.Write(arrayUpdated[i, n] + " ");
                    }
                    //Console.WriteLine();
                }
            }
            */

            //izdruka
            /*
            Console.WriteLine("Jaunais masīvs: " + arrayUpdated.GetLength(0) + " " + arrayUpdated.GetLength(1));
            for (int i = 0; i < arrayUpdated.GetLength(0); i++)
            {
                    for (int n = 0; n < arrayUpdated.GetLength(1); n++)
                    {
                        //Console.WriteLine("kolonna = i:" + i + " / n: " + n);
                        Console.Write(arrayUpdated[i, n] + " ");
                    }
                    Console.WriteLine();

            }
            */

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
            // Prepare values for saving using MyEvent object class
            try
            {
                // Validate day field
                try
                {
                    if (tb_Day.Text != null && tb_Day.Text.Length == 0)
                    {
                        MessageBox.Show("Day value not entered", "Error", MessageBoxButtons.OK);
                        tb_Day.Focus();
                        tb_Day.Clear();
                        return;
                    }
                    else if ((int.Parse(tb_Day.Text) >= 1) && (int.Parse(tb_Day.Text) <= 31))
                    {
                        MyEvent.day = int.Parse(tb_Day.Text);
                    }
                    else
                    {
                        MessageBox.Show("Incorect day value", "Error", MessageBoxButtons.OK);
                        tb_Day.Focus();
                        tb_Day.Clear();
                        return;
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
                    tb_Day.Focus();
                }

                // Validate month field
                if (cb_Month.Text != null && cb_Month.Text.Length == 0)
                {
                    MessageBox.Show("Month value not choosen", "Error", MessageBoxButtons.OK);
                    cb_Month.Focus();
                    return;
                }
                else
                {
                    MyEvent.month = (MonthEnums)Enum.Parse(typeof(MonthEnums), Convert.ToString(cb_Month.Text));
                }

                // Validate type field
                if (cb_Type.Text != null && cb_Type.Text.Length == 0)
                {
                    MessageBox.Show("Event type not selected", "Error", MessageBoxButtons.OK);
                    cb_Type.Focus();
                    return;
                }
                else
                {
                    MyEvent.type = MyEvent.GetTypeValue(cb_Type.Text);
                }

                // Validate name field
                if (tb_Name.Text != null && tb_Name.Text.Length == 0)
                {
                    MessageBox.Show("Name not entered", "Error", MessageBoxButtons.OK);
                    tb_Name.Focus();
                    return;
                }
                else
                {
                    MyEvent.name = tb_Name.Text;
                }

                // Manage year field
                if ((chb_SkipYear.Checked == true) | (chb_SkipYear.Checked == false && string.IsNullOrEmpty(tb_Year.Text)))
                {
                    MyEvent.year = 0000;
                }
                else
                {
                    MyEvent.year = int.Parse(tb_Year.Text);
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
                return;
                throw;
            }

            if (f1.editModeOn == true)
            {
                //f1.DataTable_DeleteRecord();
                f1.DataTable_AddRecord(MyEvent.day, MyEvent.month, MyEvent.year, MyEvent.type, MyEvent.name);
            }
            else
            {
                f1.DataTable_AddRecord(MyEvent.day, MyEvent.month, MyEvent.year, MyEvent.type, MyEvent.name);
            }
            Dispose();

        }

        private void tb_Day_TextChanged(object sender, EventArgs e)
        {

        }
    }
}