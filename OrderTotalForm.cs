using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public partial class OrderTotalForm : Form
    {
        public OrderTotalForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderID.Text.Trim(), out int orderId))
            {
                lblTotal.Text = "Invalid Order ID.";
                return;
            }

            try
            {
                string connStr = "server=localhost;user=root;password=09264050857;database=jollibee_daraga;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT CalculateOrderTotal(@orderId)", conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        object result = cmd.ExecuteScalar();
                        decimal total = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        lblTotal.Text = $"Total: ₱{total:F2}";
                    }
                }
            }
            catch (Exception ex)
            {
                lblTotal.Text = "Error: " + ex.Message;
            }
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
