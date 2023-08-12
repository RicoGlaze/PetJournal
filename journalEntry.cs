using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetJournal
{
    public partial class journalEntry : Form
    {
        public journalEntry()
        {
            InitializeComponent();
        }

        private void journalEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petJournalDataBaseDataSet.petEntries' table. You can move, or remove it, as needed.
            this.petEntriesTableAdapter.Fill(this.petJournalDataBaseDataSet.petEntries);

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
    }
}
