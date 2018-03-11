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

        public bool TheValue
        {
            get { return true; }
        }

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
            string newBoard = "";
            newBoard = txtNewDashboard.Text;
            dbUtils.executeNonQuery(TaskQuery.InsertNewDashboard(newBoard));
            this.Close();
            showDialogNewDashboardSuccess("Dashboard " + newBoard + " created");
            isNewDashboard = true;
        }

        private void showDialogNewDashboardSuccess(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
