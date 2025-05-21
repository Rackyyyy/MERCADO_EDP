using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                DBConnection.conn.Open();
                string query = "SELECT * FROM employee WHERE username = @username AND password = @password";

                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Successful!");
                    // Redirect to main form
                    this.Hide();
                    MainForm dashboard = new MainForm(); // Create this form later
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
                DBConnection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgot = new ForgotPasswordForm();
            forgot.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
