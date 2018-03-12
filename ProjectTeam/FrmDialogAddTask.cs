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
        FrmDashboard frmDashboard = new FrmDashboard();

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
            try
            {
                string taskName = txtNewTaskName.Text.ToString();
                string begin = txtNewBeginDate.Text.ToString();
                string end = txtNewEndDate.Text.ToString();
                string description = txtNewDescription.Text.ToString();
                int idList = cbNewListName.SelectedIndex + 1;
                string titleList = txtNewTaskName.Text.ToString();

                if (taskName == "")
                {
                    showMessage("Please enter task name");
                    txtNewTaskName.Focus();
                }
                else if (begin == "")
                {
                    showMessage("Please enter begin date");
                    txtNewBeginDate.Focus();
                }
                else if (end == "")
                {
                    showMessage("Please enter end date");
                    txtNewEndDate.Focus();
                }
                else if (description == "")
                {
                    showMessage("Please enter description");
                    txtNewDescription.Focus();
                }
                else
                {
                    string queryInsertTask = TaskQuery.InsertNewTask(titleList, "" + idList, description, begin, end);
                    dbUtils.executeNonQuery(queryInsertTask);
                    showMessage("New task created");
                    frmDashboard.loadListTask();
                    this.Close();
                }
            }
            catch (Exception e)
            {
                showMessage(e.Message);
            }
        }

        private void showMessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
