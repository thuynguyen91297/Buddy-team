namespace ProjectTeam
{
    partial class FrmDialogAddTask
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
            this.btnCreateNewTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewEndDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewBeginDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewDescription = new System.Windows.Forms.TextBox();
            this.txtNewTaskName = new System.Windows.Forms.TextBox();
            this.btnCancelDialogNewTask = new System.Windows.Forms.Button();
            this.cbNewListName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreateNewTask
            // 
            this.btnCreateNewTask.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateNewTask.Location = new System.Drawing.Point(47, 201);
            this.btnCreateNewTask.Name = "btnCreateNewTask";
            this.btnCreateNewTask.Size = new System.Drawing.Size(268, 33);
            this.btnCreateNewTask.TabIndex = 5;
            this.btnCreateNewTask.Text = "Create new";
            this.btnCreateNewTask.UseVisualStyleBackColor = false;
            this.btnCreateNewTask.Click += new System.EventHandler(this.btnCreateNewTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create new task";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "End date :";
            // 
            // txtNewEndDate
            // 
            this.txtNewEndDate.Location = new System.Drawing.Point(136, 112);
            this.txtNewEndDate.Name = "txtNewEndDate";
            this.txtNewEndDate.Size = new System.Drawing.Size(140, 20);
            this.txtNewEndDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Begin date :";
            // 
            // txtNewBeginDate
            // 
            this.txtNewBeginDate.Location = new System.Drawing.Point(136, 77);
            this.txtNewBeginDate.Name = "txtNewBeginDate";
            this.txtNewBeginDate.Size = new System.Drawing.Size(140, 20);
            this.txtNewBeginDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Task Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name List :";
            // 
            // txtNewDescription
            // 
            this.txtNewDescription.Location = new System.Drawing.Point(433, 73);
            this.txtNewDescription.Multiline = true;
            this.txtNewDescription.Name = "txtNewDescription";
            this.txtNewDescription.Size = new System.Drawing.Size(163, 94);
            this.txtNewDescription.TabIndex = 4;
            // 
            // txtNewTaskName
            // 
            this.txtNewTaskName.Location = new System.Drawing.Point(433, 38);
            this.txtNewTaskName.Name = "txtNewTaskName";
            this.txtNewTaskName.Size = new System.Drawing.Size(163, 20);
            this.txtNewTaskName.TabIndex = 3;
            // 
            // btnCancelDialogNewTask
            // 
            this.btnCancelDialogNewTask.BackColor = System.Drawing.Color.Silver;
            this.btnCancelDialogNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDialogNewTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelDialogNewTask.Location = new System.Drawing.Point(332, 201);
            this.btnCancelDialogNewTask.Name = "btnCancelDialogNewTask";
            this.btnCancelDialogNewTask.Size = new System.Drawing.Size(268, 33);
            this.btnCancelDialogNewTask.TabIndex = 6;
            this.btnCancelDialogNewTask.Text = "Cancel";
            this.btnCancelDialogNewTask.UseVisualStyleBackColor = false;
            this.btnCancelDialogNewTask.Click += new System.EventHandler(this.btnCancelDialogNewTask_Click);
            // 
            // cbNewListName
            // 
            this.cbNewListName.FormattingEnabled = true;
            this.cbNewListName.Location = new System.Drawing.Point(136, 38);
            this.cbNewListName.Name = "cbNewListName";
            this.cbNewListName.Size = new System.Drawing.Size(140, 21);
            this.cbNewListName.TabIndex = 0;
            // 
            // FrmDialogAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 246);
            this.Controls.Add(this.cbNewListName);
            this.Controls.Add(this.btnCancelDialogNewTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNewEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewBeginDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewDescription);
            this.Controls.Add(this.txtNewTaskName);
            this.Controls.Add(this.btnCreateNewTask);
            this.Controls.Add(this.label1);
            this.Name = "FrmDialogAddTask";
            this.Text = "FormDialogAddTask";
            this.Load += new System.EventHandler(this.FormDialogAddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewBeginDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewDescription;
        private System.Windows.Forms.TextBox txtNewTaskName;
        private System.Windows.Forms.Button btnCancelDialogNewTask;
        private System.Windows.Forms.ComboBox cbNewListName;
    }
}