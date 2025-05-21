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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.conn.Open();
                string query = "SELECT security_question FROM employee WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblSecQ.Text = reader["security_question"].ToString();
                }
                else
                {
                    MessageBox.Show("Username not found.");
                }
                DBConnection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.conn.Open();
                string query = "SELECT * FROM employee WHERE username = @username AND security_answer = @answer";
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@answer", txtSecAnswer.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close(); // Close reader before executing next command
                    string updateQuery = "UPDATE employee SET password = @newpass WHERE username = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, DBConnection.conn);
                    updateCmd.Parameters.AddWithValue("@newpass", txtNewPass.Text);
                    updateCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Password reset successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect answer.");
                }
                DBConnection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
