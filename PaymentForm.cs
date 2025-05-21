using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            cmbMethod.Items.AddRange(new string[] { "Cash", "GCash", "Credit Card" });
            cmbMethod.SelectedIndex = 0;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderID.Text.Trim(), out int orderId))
            {
                lblMessage.Text = "Invalid Order ID.";
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
            {
                lblMessage.Text = "Invalid amount.";
                return;
            }

            string method = cmbMethod.SelectedItem.ToString();

            try
            {
                ProcessPayment(orderId, amount, method);
                lblMessage.Text = "Payment successful!";
            }
            catch (MySqlException ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        private void ProcessPayment(int orderId, decimal amount, string method)
        {
            string connStr = "server=localhost;user=root;password=09264050857;database=jollibee_daraga;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("ProcessPayment", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_order_id", orderId);
                    cmd.Parameters.AddWithValue("p_amount", amount);
                    cmd.Parameters.AddWithValue("p_method", method);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {

        }
    }
}