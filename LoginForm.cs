using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (IsLoginSuccessful(username, password))
            {
                lblMessage.Text = "Login Successful.";
            }
            else
            {
                HandleFailedLogin(username);
                lblMessage.Text = "Invalid login. Please try again.";
            }
        }

        private bool IsLoginSuccessful(string username, string password)
        {
            string connStr = "server=localhost;user=root;password=your_password;database=jollibee_daraga;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        private void HandleFailedLogin(string username)
        {
            string connStr = "server=localhost;user=root;password=09264050857;database=jollibee_daraga;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE users SET failed_attempts = failed_attempts + 1, last_failed_login = NOW() WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

