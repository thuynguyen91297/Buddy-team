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
using System.Data;

namespace ProjectTeam
{
    public partial class FrmLogIn : Form
    {
        Sqlcommands cmd = new Sqlcommands();
        public FrmLogIn()
        {
            InitializeComponent();
        }
        //string ConnectionString = @"Data Source=DESKTOP-T73FOFC\SQLEXPRESS;Initial Catalog=BuddyTeam;Integrated Security=True";
        static int attempt = 5;
        private bool check(string email,string password)
        {
            string[] para = { "email", "password" };
            string[] values = { email, password };
            if(cmd.getDataTableStoredProcedure(para,values,"USP_Login" ).Rows.Count>0)
            {
                return true;
            }
            return false;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if(check (tbUserName.Text,tbPassword.Text))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên Tài khoản rồi nhaaaaaa");
            }
        }

        private void lbCreatAcc_Click(object sender, EventArgs e)
        {
            FrmSignUp fm = new FrmSignUp();
            fm.Show();
        }
    }

}