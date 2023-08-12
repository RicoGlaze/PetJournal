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
    public partial class journalEntry : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;

        public journalEntry()
        {
            InitializeComponent();
        }

        private void journalEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petJournalDataBaseDataSet1.petEntries' table. You can move, or remove it, as needed.
            //this.petEntriesTableAdapter1.Fill(this.petJournalDataBaseDataSet1.petEntries);
            // TODO: This line of code loads data into the 'petJournalDataBaseDataSet.petEntries' table. You can move, or remove it, as needed.
            //this.petEntriesTableAdapter.Fill(this.petJournalDataBaseDataSet.petEntries);
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergi\source\repos\PetJournal\PetJournalDataBase.mdf;Integrated Security=True");

            string query = "SELECT title,date FROM petEntries";
            SqlCommand command = new SqlCommand(query, cn);

            cn.Open();

            using (SqlDataReader reader = command.ExecuteReader())

                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    DateTime value2 = reader.GetDateTime(1);
                    journalListBox.Items.Add(value + "," + value2.ToShortDateString());
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void journalEntryBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userDash dash = new userDash();
            dash.ShowDialog();
        }

        private void journalEntrySubmitBtn_Click(object sender, EventArgs e)
        {
            DateTime dateVar = DateTime.Now;
            if (journalTitleTxt.Text != string.Empty)
            {
                cmd = new SqlCommand("insert into petEntries values(@title,@date,@entry)", cn);
                cmd.Parameters.AddWithValue("title", journalTitleTxt.Text);
                cmd.Parameters.AddWithValue("date", dateVar);
                cmd.Parameters.AddWithValue("entry", journalEntryRichTxt.Text);
                cmd.ExecuteNonQuery();
                // ToDo Manually add a row to the dataset and fill with the added data
                //this.petEntriesTableAdapter1.Update(this.petJournalDataBaseDataSet1.petEntries);
                //this.petEntriesTableAdapter1.Fill(this.petJournalDataBaseDataSet1.petEntries);
                //journalDataGrid.Update();
                //journalDataGrid.Refresh();
                this.Hide();
                journalEntry entry = new journalEntry();
                entry.ShowDialog();
                MessageBox.Show("Your Entry was added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a Title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void journalTableDeleteBtn_Click(object sender, EventArgs e)
        {
            string[] arr = journalListBox.Text.Split(',');
            string query = "delete from petEntries where title='" + arr[0] + "';";
            SqlCommand command = new SqlCommand(query, cn);

            //cn.Open();

            using (SqlDataReader reader = command.ExecuteReader())

                while (reader.Read())
                {
                }
            this.Hide();
            journalEntry entry = new journalEntry();
            entry.ShowDialog();
            MessageBox.Show("Your Entry was removed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void journalTableLoadBtn_Click(object sender, EventArgs e)
        {
            string[] arr = journalListBox.Text.Split(',');
            string query = "select entry from petEntries where title='" + arr[0] + "';";
            SqlCommand command = new SqlCommand(query, cn);

            using (SqlDataReader reader = command.ExecuteReader())

                if (reader.Read())
                {
                    journalTitleTxt.Text = arr[0];
                    journalEntryRichTxt.Text = reader.GetString(0);
                }
            //this.Hide();
            //journalEntry entry = new journalEntry();
            //entry.ShowDialog();
            MessageBox.Show("Your Entry was loaded.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
