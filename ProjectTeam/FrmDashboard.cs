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
    public partial class FrmDashboard : Form
    {
        DatabaseUtils dbUtilsDashboard;
        private DataSet dsTask;

        public FrmDashboard()
        {
            InitializeComponent();
            dbUtilsDashboard = new DatabaseUtils();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            if (dbUtilsDashboard.open())
            {
                loadListTask();
                dbUtilsDashboard.close();
            }
            else
            {
                MessageBox.Show("Fail! Cant't load datagridview");
            }
        }

        public void loadListTask()
        {
            try
            {
                dsTask = dbUtilsDashboard.getDataSet(TaskQuery.GET_TASKS_FROM_CARD(MainForm.indexDashboard));
                dbUtilsDashboard.load_dgv(TaskQuery.GET_TASKS_FROM_CARD(MainForm.indexDashboard), dsTask, dgvTasks);
            }
            catch (Exception ex)
            {
                dbUtilsDashboard.errorMessage(208);
            }
        }

        /*
         *  event for cell in data gridview 
         */
        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvTasks.Rows[rowIndex];
            try
            {                 
                loadComboBoxNameList(int.Parse(row.Cells[1].Value.ToString()));
                txtIdTask.Text = row.Cells[1].Value.ToString();
                txtTaskName.Text = row.Cells[2].Value.ToString();
                txtDescription.Text = row.Cells[3].Value.ToString();
                txtBeginDate.Text = row.Cells[4].Value.ToString();
                txtEndDate.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                dbUtilsDashboard.errorMessage(208);
            }
        }

        private void loadComboBoxNameList(int idCard)
        {
            try
            {
                string query = TaskQuery.GetList(idCard);
                SqlDataAdapter da = new SqlDataAdapter(query, dbUtilsDashboard.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds, "List");
                cbNameList.DisplayMember = "Title";
                cbNameList.ValueMember = "IDList";
                cbNameList.DataSource = ds.Tables["List"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Error when load combobox name list");
            }
        }

        /*
         * Click add task in Doard 
         * Show from add new task 
        */
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            FrmDialogAddTask frmDialogAdd = new FrmDialogAddTask();
            frmDialogAdd.ShowDialog(this);
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(TaskQuery.UPDATE_TASK, dbUtilsDashboard.getConnection());
                cmd.Parameters.AddWithValue("@IDCard", txtIdTask);
                cmd.Parameters.AddWithValue("@TaskName", txtTaskName);
                //cmd.Parameters.AddWithValue("@IDList", txtNameList);
                cmd.Parameters.AddWithValue("@decription", txtDescription);
                cmd.Parameters.AddWithValue("@beginDate", txtBeginDate);
                cmd.Parameters.AddWithValue("@endDate", txtEndDate);
                //dbUtilsDashboard.executeNonQuery(TaskQuery.UPDATE_TASK);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nice! Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong. You cann't update");
            }
            
        }

        private void convertDate(string cdate, TextBox txtDate)
        {
            DateTime subDateTime = new DateTime();
            subDateTime = DateTime.ParseExact(cdate, "MM-dd-yyyy", null);
            string converted_date = subDateTime.ToString("dd-MM-yyyy");
            txtDate.Text = converted_date;
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            string strIdTask = txtIdTask.Text.ToString();
            string strTaskName = txtTaskName.Text.ToString();
            dbUtilsDashboard.executeNonQuery(TaskQuery.DeleteTask(strIdTask));
            MessageBox.Show("" + strTaskName + "deleted!");
            clear();
            loadListTask();
        }

        private void clear()
        {
            txtIdTask.Text = txtTaskName.Text = txtEndDate.Text = txtDescription.Text = txtBeginDate.Text = "";
        }
    }
}
