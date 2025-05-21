using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public partial class InsertOrderForm : Form
    {
        public InsertOrderForm()
        {
            InitializeComponent();
        }

        private void InsertOrderForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            int customerId, employeeId, productId, quantity;
            decimal totalAmount;

            if (!int.TryParse(txtCustomerID.Text, out customerId) ||
                !int.TryParse(txtEmployeeID.Text, out employeeId) ||
                !int.TryParse(txtProductID.Text, out productId) ||
                !int.TryParse(txtQuantity.Text, out quantity) ||
                !decimal.TryParse(txtTotalAmount.Text, out totalAmount))
            {
                MessageBox.Show("Please enter valid input values.");
                return;
            }

            string connStr = "server=localhost;user=root;password=09264050857;database=jollibee_daraga;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("InsertOrder", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_customer_id", customerId);
                    cmd.Parameters.AddWithValue("p_employee_id", employeeId);
                    cmd.Parameters.AddWithValue("p_product_id", productId);
                    cmd.Parameters.AddWithValue("p_quantity", quantity);
                    cmd.Parameters.AddWithValue("p_total_amount", totalAmount);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
