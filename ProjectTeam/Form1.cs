﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
            
        }
        MainForm mainForm = new MainForm();
        private void btLogin_Click(object sender, EventArgs e)
        {
            
            //mainForm = new MainForm();
            mainForm.Show();
            mainForm.Activate();
            
            // this.Close();
        }

        private void lbCreatAcc_Click(object sender, EventArgs e)
        {
            FrmSignUp fm = new FrmSignUp();
            fm.Show();
        }
    }

}