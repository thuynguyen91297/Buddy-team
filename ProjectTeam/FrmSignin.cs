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
        
        private bool check(string email, string password)
        {
            

            string[] para = { "email", "password" };
            string[] values = { email, password };
            if(cmd.getDataTableStoredProcedure(para,values,"USP_Login" ).Rows.Count>0)
            {
                return true;
            }
            return false;
        }

        static int attempt = 5;
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ email, password vào nhé");
            }
            else
            {
                if (check (tbUserName.Text,tbPassword.Text))
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
        }
        FrmSignUp fm = new FrmSignUp();

        private void lbCreatAcc_Click(object sender, EventArgs e)
        {
            //this.Hide();
            fm.Show();
        }

        
    }

}