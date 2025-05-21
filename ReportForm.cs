using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_8_BACKEND
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            string query = "SELECT * FROM orders WHERE CONCAT(order_id, customer_id, employee_id, total_amount, status) LIKE @keyword";

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=09264050857;database=jollibee_daraga;"))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + searchKeyword + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewReport.DataSource = table;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        DataTable dt = ((DataTable)dataGridViewReport.DataSource);
                        workbook.Worksheets.Add(dt, "OrdersReport");
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Report exported successfully.");
                }
            }
        }
    }
}
