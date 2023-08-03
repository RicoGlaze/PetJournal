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
    public partial class userDash : Form
    {
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
    }
}
