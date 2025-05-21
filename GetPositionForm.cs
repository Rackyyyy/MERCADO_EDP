using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public partial class GetPositionForm : Form
    {
        public GetPositionForm()
        {
            InitializeComponent();
        }

        private void btnGetPosition_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmpID.Text.Trim(), out int empId))
            {
                lblPosition.Text = "Invalid ID.";
                return;
            }

            try
            {
                string connStr = "server=localhost;user=root;password=09264050857;database=jollibee_daraga;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT GetEmployeePosition(@id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", empId);

                        object result = cmd.ExecuteScalar();
                        lblPosition.Text = "Position: " + result?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblPosition.Text = "Error: " + ex.Message;
            }
        }
    }
}
