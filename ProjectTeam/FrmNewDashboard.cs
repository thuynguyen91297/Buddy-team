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
    public partial class FrmNewDashboard : Form
    {
        //FrmNewDashboard frmNewDashboard;
        public FrmNewDashboard()
        {
            InitializeComponent();
        }

        private void btnCancelNewDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
