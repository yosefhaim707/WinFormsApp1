using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SampleTable;";
            DataTable dt = Connection.MakeQuery(query);
            dataGridView_Show.DataSource = dt;
        }
    }
}
