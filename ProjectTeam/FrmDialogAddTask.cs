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
    public partial class FrmDialogAddTask : Form
    {
        DatabaseUtils dbUtils;
        public FrmDialogAddTask()
        {
            InitializeComponent();
            dbUtils = new DatabaseUtils();
        }

        private void btnCancelDialogNewTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDialogAddTask_Load(object sender, EventArgs e)
        {
            loadComboBoxNameList();
        }

        private void loadComboBoxNameList()
        {
            try
            {
                string query = TaskQuery.GET_NAME_LIST;
                SqlDataAdapter da = new SqlDataAdapter(query, dbUtils.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds, "List");
                cbNewListName.DisplayMember = "Title";
                cbNewListName.ValueMember = "IDList";
                cbNewListName.DataSource = ds.Tables["List"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Error when load combobox name list");
            }
        }

        private void btnCreateNewTask_Click(object sender, EventArgs e)
        {
            addNewTask();
        }

        /*
         * Mehtod add dashboard, create new project
         * no param         
         */
        private void addNewTask()
        {

        }
    }
}
