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

        public static int indexDashboard;

        public MainForm()
        {
            InitializeComponent();
            dbUtils = new DatabaseUtils();
            if (FrmNewDashboard.isNewDashboard)
            {
                loadListDashboard();
            }
        }

        /*
         * method click button add new dashboard
         * param <"event">
         */
        private void picBoxNewDashboard_Click(object sender, EventArgs e)
        {
            showDialogAddingNewDashboard();
        }

        private void showDialogAddingNewDashboard()
        {
            FrmNewDashboard frmNewDashboard = new FrmNewDashboard();
            frmNewDashboard.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadListDashboard();
        }

        private void cbListDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexDashboard = cbListDashboard.SelectedIndex;
            displayPanelTwoWithDashboard();
        }

        /*
         *  choose dashboard to show panel 2 in beside
         *  
         */
        private void displayPanelTwoWithDashboard()
        {
            frmDashboard = new FrmDashboard();
            splitContainerMain.Panel2.Controls.Clear();
            splitContainerMain.Panel2.Visible = true;
            frmDashboard = new FrmDashboard();
            frmDashboard.MdiParent = this;
            splitContainerMain.Panel2.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        /*
         *  method load list dashboard
         *  no param
         */
        public void loadListDashboard()
        {
            try
            {
                string query = TaskQuery.GET_LIST_DASHBOARD;
                SqlDataAdapter da = new SqlDataAdapter(query, dbUtils.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds, "Board");
                cbListDashboard.DisplayMember = "Title";
                cbListDashboard.ValueMember = "IDBoard";
                cbListDashboard.DataSource = ds.Tables["Board"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Error when load combobox dashboard");
            }
        }
    }
}
