using System;
using System.Data;
using System.Windows.Forms;

namespace Birthday_Calendar
{
    public partial class FormMain : Form
    {
        private readonly DataGridView myeventsDataGrdView = new DataGridView();
        public FormAddReminder frm_AddReminder = new FormAddReminder();
        public string activeMonth = DateTime.Now.ToString("MMMMM");

        public static String[,] mydataarray = new String[,] {
                { "10", "oktobris", "1959", "Dz", "Inga Āboltiņa" },
                { "10", "oktobris", null, "Vd", "Arvīds Ore" },
                { "13", "oktobris", "1963", "Dz", "Grata Upeniece" },
                { "13", "oktobris", "1989", "Dz", "Kristaps Krūklis" },
                { "17", "oktobris", "1992", "M", "Tēta" },
                { "19", "oktobris", null, "Vd", "Elīna Cielava" },
                { "31", "oktobris", null, "C", "Helovīns" },
                { "06", "novembris", "1985", "Dz", "Aija Liepiņa" },
                { "13", "novembris", "1941", "Dz", "Sarma Grūbe" },
                { "29", "novembris", null, "Dz", "Dzidra Kavace" }
            };
        public static int selected_row;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_ReminderTable.DataSource = MyDataTable();

            // Manage column width of DataGridView table
            dgv_ReminderTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_ReminderTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_ReminderTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_ReminderTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_ReminderTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private DataTable MyDataTable()
        {

            DataTable dtMyEvents = new DataTable("MyDataTable");

            //Create columns and add to DataTable;
            dtMyEvents.Columns.Add("Day", typeof(int));
            dtMyEvents.Columns.Add("Month");
            dtMyEvents.Columns.Add("Year", typeof(String));
            dtMyEvents.Columns.Add("Type");
            dtMyEvents.Columns.Add("Name", typeof(String));

            DataRow dr;
            for (int count = 0; count <= mydataarray.GetLength(0) - 1; count++)
            {

                if (mydataarray[count, 1] == activeMonth)
                {
                    dr = dtMyEvents.NewRow();
                    dr["Day"] = mydataarray[count, 0];
                    dr["Month"] = mydataarray[count, 1];
                    dr["Year"] = mydataarray[count, 2];
                    dr["Type"] = mydataarray[count, 3];
                    dr["Name"] = mydataarray[count, 4];
                    dtMyEvents.Rows.Add(dr);
                }

            }

            return dtMyEvents;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = dgv_ReminderTable;
            int r = dgv.CurrentRow.Index;

            // Determine selected row number for deletion purpose
            selected_row = r;

            MyEvent.day = Convert.ToInt32(dgv[0, r].Value);
            MyEvent.month = (MonthEnums)Enum.Parse(typeof(MonthEnums), Convert.ToString(dgv[1, r].Value));

            if (dgv.Rows[r].Cells[2].Value == null || dgv.Rows[r].Cells[2].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgv.Rows[r].Cells[2].Value.ToString()))
            {
                MyEvent.year = 0000;
            }
            else
            {
                MyEvent.year = Convert.ToInt32(dgv[2, r].Value);
            }

            MyEvent.type = (TypeEnums)Enum.Parse(typeof(TypeEnums), Convert.ToString(dgv[3, r].Value));
            MyEvent.name = Convert.ToString(dgv[4, r].Value);

            var f = new FormAddReminder();
            f.ShowDialog();

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frm_AddReminder.Show();
        }

        private void mc_Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            activeMonth = mc_Calendar.SelectionRange.Start.ToString("MMMMM");
            dgv_ReminderTable.DataSource = MyDataTable();
        }

    }
}
