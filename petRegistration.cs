﻿using System;
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
        public petRegistration()
        {
            InitializeComponent();
        }

        private void petRegistration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergi\source\repos\PetJournal\PetJournalDataBase.mdf;Integrated Security=True");
            cn.Open();
        }
    }
}
