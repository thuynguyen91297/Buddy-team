namespace ProjectTeam
{
    partial class FrmToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lvTasks = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(2, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvTasks
            // 
            this.lvTasks.AllowDrop = true;
            this.lvTasks.Location = new System.Drawing.Point(2, 0);
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.Size = new System.Drawing.Size(243, 166);
            this.lvTasks.TabIndex = 1;
            this.lvTasks.UseCompatibleStateImageBehavior = false;
            this.lvTasks.View = System.Windows.Forms.View.Tile;
            this.lvTasks.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvTasks_ItemDrag);
            this.lvTasks.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvTasks_DragEnter);
            this.lvTasks.DragOver += new System.Windows.Forms.DragEventHandler(this.lvTasks_DragOver);
            // 
            // FrmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 204);
            this.Controls.Add(this.lvTasks);
            this.Controls.Add(this.button1);
            this.Name = "FrmToDoList";
            this.Text = "To do list";
            this.Load += new System.EventHandler(this.FrmToDoList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvTasks;
    }
}