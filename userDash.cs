using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PetJournal
{
    public partial class userDash : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlConnection sql;

        public userDash()
        {
            InitializeComponent();
        }

        private void userDashPetRegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            petRegistration registration = new petRegistration();
            registration.ShowDialog();
        }

        private void userDash_Load(object sender, EventArgs e)
        {
            //on Form load this populates the added pets section with the pet names in the database
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergi\source\repos\PetJournal\PetJournalDataBase.mdf;Integrated Security=True");

            string query = "SELECT pet_name FROM userPets";
            SqlCommand command = new SqlCommand(query, cn);

            cn.Open();

            using (SqlDataReader reader = command.ExecuteReader())

            while (reader.Read())
            {
                string value = reader.GetString(0);
                listBox1.Items.Add(value);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //in progress
            //This is suppose to retrieve the pet_photo data and convert it back into an image
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergi\source\repos\PetJournal\PetJournalDataBase.mdf;Integrated Security=True";
            string query = "SELECT pet_photo FROM userPets WHERE pet_name = @pet_name";
            //string query2 = "SELECT pet_name FROM userPets WHERE pet_name = @pet_name";

            string desiredPetName = listBox1.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@pet_name", desiredPetName);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["pet_photo"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                Image image = Image.FromStream(ms);
                                userDashPetBlob.Image = image;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Pet image not found.");
                        }
                    }
                }
            }
        }
    }
}
