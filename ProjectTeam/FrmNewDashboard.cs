using System;
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
        DatabaseUtils dbUtils;
        MainForm main;

        public static bool isNewDashboard = false;

        public FrmNewDashboard()
        {
            InitializeComponent();
            dbUtils = new DatabaseUtils();
        }

        private void btnCancelNewDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateNewDashBoard_Click(object sender, EventArgs e)
        {
            if (txtNewDashboard.Text == "")
            {
                showDialogReport("Please enter new dashboard !");
                txtNewDashboard.Focus();
            }
            else
            {
                dbUtils.executeNonQuery(TaskQuery.InsertNewDashboard(txtNewDashboard.Text.ToString()));
                this.Close();
                showDialogReport("Dashboard " + txtNewDashboard.Text + " created");
                isNewDashboard = true;
            }
        }

        private void showDialogReport(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
