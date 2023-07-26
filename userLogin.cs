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
    public partial class userLogin : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public userLogin()
        {
            InitializeComponent();
        }

        private void userLogin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergi\source\repos\PetJournal\PetJournalDataBase.mdf;Integrated Security=True");
            cn.Open();
        }

        private void userLoginRegisterLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            userRegistration registration = new userRegistration();
            registration.ShowDialog();
        }

        private void userLoginBtn_Click(object sender, EventArgs e)
        {
            if (passwordLoginTxt.Text != string.Empty || usernameLoginTxt.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from petJournalUsers where username='" + usernameLoginTxt.Text + "' and password='" + passwordLoginTxt.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    userDash home = new userDash();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
