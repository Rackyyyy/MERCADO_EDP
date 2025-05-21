using System;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public partial class ArchivedOrdersForm : Form
    {
        public ArchivedOrdersForm()
        {
            InitializeComponent();
        }

        private void ArchivedOrdersForm_Load(object sender, EventArgs e)
        {
            LoadArchivedOrders();
        }

        private void LoadArchivedOrders()
        {
            string connStr = "server=localhost;user=root;password=your_password;database=jollibee_daraga;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM archived_orders ORDER BY archived_at DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewArchived.DataSource = table;
            }
        }

        private void dataGridViewArchived_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

