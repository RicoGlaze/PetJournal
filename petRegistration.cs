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
    public partial class petRegistration : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;

        public petRegistration()
        {
            InitializeComponent();
        }

        private void petRegistration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergi\source\repos\PetJournal\PetJournalDataBase.mdf;Integrated Security=True");
            cn.Open();
        }

        private void petRegistrationUploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;)|*.jpg;*.jpeg;.*.gif";

            if(opnfd.ShowDialog()==DialogResult.OK)
            {
                petRegistrationBlobBox.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void petRegistrationRegisterBtn_Click(object sender, EventArgs e)
        {
            if (petRegistrationNameTxt.Text != string.Empty || petRegistrationAgeTxt.Text != string.Empty || petRegistrationBreedTxt.Text != string.Empty)
            {
                cmd = new SqlCommand("insert into userPets values(@pet_name,@pet_age,@pet_breed,@pet_photo)", cn);
                cmd.Parameters.AddWithValue("pet_name", petRegistrationNameTxt.Text);
                cmd.Parameters.AddWithValue("pet_age", petRegistrationAgeTxt.Text);
                cmd.Parameters.AddWithValue("pet_breed", petRegistrationBreedTxt.Text);
                cmd.Parameters.AddWithValue("pet_photo", petRegistrationBlobBox.Image.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Pet was added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
