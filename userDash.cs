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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetJournal
{
    public partial class userDash : Form
    {
        private SqlConnection cn;

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
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergi\source\repos\PetJournal\PetJournalDataBase.mdf;Integrated Security=True");
            //cn.Open();

            string query = "SELECT petName FROM TestTable";
            SqlCommand command = new SqlCommand(query, cn);

            cn.Open();

            using (SqlDataReader reader = command.ExecuteReader())

            while (reader.Read())
            {
                string value = reader.GetString(0); // Assuming data is stored as strings

                    // Step 4: Add the value to the ListView
                    userDashPetList.Items.Add(value);
                }
            //cn.Close();
        }
    }
}
