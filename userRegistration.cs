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

namespace PetJournal
{
    public partial class userRegistration : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public userRegistration()
        {
            InitializeComponent();
        }

        private void userRegistration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergi\source\repos\PetJournal\petOwner.mdf;Integrated Security=True");
            cn.Open();
        }

        private void userRegBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userLogin login = new userLogin();
            login.ShowDialog();
        }

        private void userRegSubmitBtn_Click(object sender, EventArgs e)
        {
            if (passwordConfirmRegTxt.Text != string.Empty || passwordRegTxt.Text != string.Empty || usernameRegTxt.Text != string.Empty)
            {
                if (passwordRegTxt.Text == passwordConfirmRegTxt.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + usernameRegTxt.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", usernameRegTxt.Text);
                        cmd.Parameters.AddWithValue("password", passwordRegTxt.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}