using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectTeam
{
    public partial class MainForm : Form
    {

        DatabaseUtils dbUtils;
        FrmDashboard frmDashboard;

        public MainForm()
        {
            InitializeComponent();
            dbUtils = new DatabaseUtils();
            loadDatabase();
        }
        public void loadDatabase() {
            if (dbUtils.open())
            {
                MessageBox.Show("Connect Success");
            }
            else
            {
                MessageBox.Show("Connect Fail");
            }
        }

        private void btnDashboardOne_Click(object sender, EventArgs e)
        {
            frmDashboard = new FrmDashboard();
            splitContainerMain.Panel2.Controls.Clear();
            splitContainerMain.Panel2.Visible = true;
            frmDashboard = new FrmDashboard();
            frmDashboard.MdiParent = this;
            splitContainerMain.Panel2.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void picBoxNewDashboard_Click(object sender, EventArgs e)
        {
            showDialogAddingNewDashboard();
        }

        private void showDialogAddingNewDashboard()
        {
            FrmNewDashboard frmNewDashboard = new FrmNewDashboard();
            frmNewDashboard.ShowDialog(this);
            
        }
    }
}
