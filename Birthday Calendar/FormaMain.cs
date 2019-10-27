using System;
using System.Windows.Forms;

namespace Birthday_Calendar
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_NewReminder_Click(object sender, EventArgs e)
        {
            FormAddReminder frm_AddReminder = new FormAddReminder();
            frm_AddReminder.Show();
        }
    }
}
