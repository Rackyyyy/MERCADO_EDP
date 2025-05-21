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
    public partial class UserControlForm : Form
    {
        public UserControlForm()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            string query = "SELECT * FROM employee";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridViewUsers.DataSource = dt;
        }


        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();
                txtUsername.Text = row.Cells[3].Value.ToString();
                txtPassword.Text = row.Cells[4].Value.ToString();
                txtSecQ.Text = row.Cells[5].Value.ToString();
                txtSecAns.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO employee (firstname, lastname, username, password, security_question, security_answer) VALUES (@fn, @ln, @un, @pw, @sq, @sa)";

            DBConnection.conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
            cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
            cmd.Parameters.AddWithValue("@un", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
            cmd.Parameters.AddWithValue("@sq", txtSecQ.Text);
            cmd.Parameters.AddWithValue("@sa", txtSecAns.Text);

            cmd.ExecuteNonQuery();
            DBConnection.conn.Close();

            MessageBox.Show("User added successfully!");
            LoadUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString());

                string query = "UPDATE employee SET firstname=@fn, lastname=@ln, username=@un, password=@pw, security_question=@sq, security_answer=@sa WHERE id=@id";
                DBConnection.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text);
                cmd.Parameters.AddWithValue("@un", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                cmd.Parameters.AddWithValue("@sq", txtSecQ.Text);
                cmd.Parameters.AddWithValue("@sa", txtSecAns.Text);
                cmd.ExecuteNonQuery();
                DBConnection.conn.Close();

                MessageBox.Show("User updated.");
                LoadUsers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString());

                string query = "DELETE FROM employee WHERE id=@id";
                DBConnection.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                DBConnection.conn.Close();

                MessageBox.Show("User deleted.");
                LoadUsers();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtSecQ.Clear();
            txtSecAns.Clear();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSecQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
