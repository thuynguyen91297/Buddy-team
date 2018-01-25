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
    public partial class MainForm : Form
    {
        FrmToDoList frmToDoList = new FrmToDoList();
        FrmNewDashboard frmNewDashboard = new FrmNewDashboard();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDashboard1_Click(object sender, EventArgs e)
        {
            frmToDoList.MdiParent = this;
            frmToDoList.StartPosition = FormStartPosition.Manual;
            frmToDoList.Top = 50;
            frmToDoList.Left = 120;
            frmToDoList.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmNewDashboard.MdiParent = this;
            frmNewDashboard.StartPosition = FormStartPosition.Manual;
            frmNewDashboard.Top = 50;
            frmNewDashboard.Left = 120;
            frmNewDashboard.Show();
        }
    }
}
