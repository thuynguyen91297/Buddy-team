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
        string SQLString = @"Data Source=DESKTOP-T73FOFC\SQLEXPRESS;Initial Catalog=BuddyTeam;Integrated Security=True";
        SqlConnection cnn;
        FrmToDoList frmToDoList = new FrmToDoList();
        FrmNewDashboard frmNewDashboard = new FrmNewDashboard();
        public MainForm()
        {

            InitializeComponent();
            LoadCSDL();
        }
        Boolean LoadCSDL() {
            try
            {
                cnn = new SqlConnection(SQLString);
                cnn.Open();
                MessageBox.Show("Connected");
                return true;
            
            }
            catch (Exception e)
            {
                MessageBox.Show("False");
                return false;
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
