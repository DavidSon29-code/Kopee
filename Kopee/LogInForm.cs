using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Kopee
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\RenzP\\OneDrive\\Documents\\FrontDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label7_Click(object sender, EventArgs e)
        {
            GetStarted gt = new GetStarted();
            gt.Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            GetStarted gt1 = new GetStarted();
            gt1.Show();
            this.Hide();
            // 1.
            try
            {
                if (Email_Reg.Text!="" && Username_Reg.Text != "" && Password_Reg.Text != "" && Con_Reg.Text != "")
                {
                    if (Password_Reg.Text == Con_Reg.Text )
                    {
                        // 3.
                        int v = check(Email_Reg.Text);
                        if (v!=1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into RegistrationTbl values(@email,@username,@password)", connection);
                            command.Parameters.AddwithValue("@Email", Email_Reg.Text);
                            command.Parameters.AddwithValue("@Username", Username_Reg.Text);
                            command.Parameters.AddwithValue("@Password", Password_Reg.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Registered Successfully!");

                            Email_Reg.Text = "";
                            Username_Reg.Text = "";
                            Password_Reg.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Email is already registered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password do not match");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the blanks");
                }
            }
            catch (Exception ex)
            {

            }
        }
        // 2.
        int check(string email)
        {
            connection.Open();
            string query = "select count(*) from RegistrationTbl where email='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                Password_Reg.UseSystemPasswordChar = true;
                Con_Reg.UseSystemPasswordChar = true;
            }
            else
            {
                Password_Reg.UseSystemPasswordChar = false;
                Con_Reg.UseSystemPasswordChar = false;
            }
        }
    }
}
