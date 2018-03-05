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
    public partial class FrmToDoList : Form
    {
        DatabaseUtils dbUtils = new DatabaseUtils();
        String[] listTask = { "nấu bánh tết", "ăn bánh canh", "ăn cơm" };

        bool privateDrag;

        public FrmToDoList()
        {
            InitializeComponent();
            lvTasks.Font = new Font("Georgia", 16);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void FrmToDoList_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < listTask.Length; i++)
            {
                lvTasks.Items.Add(listTask[i]);
            }
        }

        private void lvTasks_ItemDrag(object sender, ItemDragEventArgs e)
        {
            privateDrag = true;
            DoDragDrop(e.Item, DragDropEffects.Copy);
            privateDrag = false;
        }

        private void lvTasks_DragEnter(object sender, DragEventArgs e)
        {
            if (privateDrag)
            {
                e.Effect = e.AllowedEffect;
            }
        }

        private void lvTasks_DragOver(object sender, DragEventArgs e)
        {
            var pos = lvTasks.PointToClient(new Point(e.X, e.Y));
            var hit = lvTasks.HitTest(pos);
            if(hit.Item != null && hit.Item.Tag != null)
            {
                var dragItem = e.Data.GetData(typeof(ListViewItem));
                copy(dragItem, (string)hit.Item.Tag);
            }
        }

        private void copy(object dragItem, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
