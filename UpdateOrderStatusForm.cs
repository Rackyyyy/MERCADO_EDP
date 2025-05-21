using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public partial class UpdateOrderStatusForm : Form
    {
        public UpdateOrderStatusForm()
        {
            InitializeComponent();
        }

        private void UpdateOrderStatusForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new string[] { "Pending", "Processing", "Shipped", "Delivered", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderID.Text.Trim(), out int orderId))
            {
                lblMessage.Text = "Invalid Order ID.";
                return;
            }

            string newStatus = cmbStatus.SelectedItem.ToString();

            try
            {
                string connStr = "server=localhost;user=root;password=09264050857;database=jollibee_daraga;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string updateQuery = "UPDATE orders SET status = @status WHERE order_id = @orderId";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        int rows = cmd.ExecuteNonQuery();

                        lblMessage.Text = rows > 0 ? "Status updated." : "⚠️ Order not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
