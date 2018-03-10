namespace ProjectTeam
{
    partial class FrmNewDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewDashboard = new System.Windows.Forms.TextBox();
            this.btnCreateNewDashBoard = new System.Windows.Forms.Button();
            this.btnCancelNewDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title : ";
            // 
            // txtNewDashboard
            // 
            this.txtNewDashboard.Location = new System.Drawing.Point(18, 86);
            this.txtNewDashboard.Multiline = true;
            this.txtNewDashboard.Name = "txtNewDashboard";
            this.txtNewDashboard.Size = new System.Drawing.Size(271, 31);
            this.txtNewDashboard.TabIndex = 2;
            // 
            // btnCreateNewDashBoard
            // 
            this.btnCreateNewDashBoard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateNewDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewDashBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateNewDashBoard.Location = new System.Drawing.Point(18, 144);
            this.btnCreateNewDashBoard.Name = "btnCreateNewDashBoard";
            this.btnCreateNewDashBoard.Size = new System.Drawing.Size(125, 33);
            this.btnCreateNewDashBoard.TabIndex = 4;
            this.btnCreateNewDashBoard.Text = "Create";
            this.btnCreateNewDashBoard.UseVisualStyleBackColor = false;
            this.btnCreateNewDashBoard.Click += new System.EventHandler(this.btnCreateNewDashBoard_Click);
            // 
            // btnCancelNewDashboard
            // 
            this.btnCancelNewDashboard.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelNewDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNewDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelNewDashboard.Location = new System.Drawing.Point(164, 144);
            this.btnCancelNewDashboard.Name = "btnCancelNewDashboard";
            this.btnCancelNewDashboard.Size = new System.Drawing.Size(125, 33);
            this.btnCancelNewDashboard.TabIndex = 5;
            this.btnCancelNewDashboard.Text = "Cancel";
            this.btnCancelNewDashboard.UseVisualStyleBackColor = false;
            this.btnCancelNewDashboard.Click += new System.EventHandler(this.btnCancelNewDashboard_Click);
            // 
            // FrmNewDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 197);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelNewDashboard);
            this.Controls.Add(this.btnCreateNewDashBoard);
            this.Controls.Add(this.txtNewDashboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmNewDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewDashboard;
        private System.Windows.Forms.Button btnCreateNewDashBoard;
        private System.Windows.Forms.Button btnCancelNewDashboard;
    }
}