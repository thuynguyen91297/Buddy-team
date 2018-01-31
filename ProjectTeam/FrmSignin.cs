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
    public partial class FrmLogIn : Form
    {
        DatabaseUtils dbUtils = new DatabaseUtils();
        DataSet ds = new DataSet();

        public FrmLogIn()
        {
            InitializeComponent();
        }
        
        private void btLogin_Click(object sender, EventArgs e)
        {
            
            if (dbUtils.open())
            {
                
                ds = dbUtils.getDataSet(TaskQuery.GET_USER_NAME);
                MessageBox.Show(ds.Tables["AccountUser"].ToString());
            }
            else
            {
                MessageBox.Show("Failed");
            }
            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please enter the field in form");
                this.tbUserName.Focus();
                this.tbPassword.Focus();
                return;
            }
            else
            {
                
            }
            
            
        }

        private void lbCreatAcc_Click(object sender, EventArgs e)
        {
            FrmSignUp fm = new FrmSignUp();
            fm.Show();
        }
    }

}