using System.Windows.Forms;

namespace Birthday_Calendar
{
    public partial class FormAddReminder : Form
    {
        public FormAddReminder()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btn_Delete_Click(object sender, System.EventArgs e)
        {

        }
    }
}