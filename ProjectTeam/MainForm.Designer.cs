namespace ProjectTeam
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxNewDashboard = new System.Windows.Forms.PictureBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnDashboardOne = new System.Windows.Forms.Button();
            this.cbListDashboard = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNewDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buddy Team Management";
            // 
            // picBoxNewDashboard
            // 
            this.picBoxNewDashboard.BackColor = System.Drawing.Color.Transparent;
            this.picBoxNewDashboard.Image = ((System.Drawing.Image)(resources.GetObject("picBoxNewDashboard.Image")));
            this.picBoxNewDashboard.Location = new System.Drawing.Point(11, 338);
            this.picBoxNewDashboard.Name = "picBoxNewDashboard";
            this.picBoxNewDashboard.Size = new System.Drawing.Size(64, 71);
            this.picBoxNewDashboard.TabIndex = 4;
            this.picBoxNewDashboard.TabStop = false;
            this.picBoxNewDashboard.Click += new System.EventHandler(this.picBoxNewDashboard_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Location = new System.Drawing.Point(-3, 38);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.cbListDashboard);
            this.splitContainerMain.Panel1.Controls.Add(this.picBoxNewDashboard);
            this.splitContainerMain.Panel1.Controls.Add(this.btnDashboardOne);
            this.splitContainerMain.Size = new System.Drawing.Size(841, 412);
            this.splitContainerMain.SplitterDistance = 178;
            this.splitContainerMain.TabIndex = 1;
            // 
            // btnDashboardOne
            // 
            this.btnDashboardOne.Location = new System.Drawing.Point(6, 29);
            this.btnDashboardOne.Name = "btnDashboardOne";
            this.btnDashboardOne.Size = new System.Drawing.Size(169, 34);
            this.btnDashboardOne.TabIndex = 0;
            this.btnDashboardOne.Text = "Dashboard 1";
            this.btnDashboardOne.UseVisualStyleBackColor = true;
            this.btnDashboardOne.Click += new System.EventHandler(this.btnDashboardOne_Click);
            // 
            // cbListDashboard
            // 
            this.cbListDashboard.FormattingEnabled = true;
            this.cbListDashboard.Location = new System.Drawing.Point(6, 5);
            this.cbListDashboard.Name = "cbListDashboard";
            this.cbListDashboard.Size = new System.Drawing.Size(169, 21);
            this.cbListDashboard.TabIndex = 5;
            this.cbListDashboard.SelectedIndexChanged += new System.EventHandler(this.cbListDashboard_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(841, 453);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNewDashboard)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxNewDashboard;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button btnDashboardOne;
        private System.Windows.Forms.ComboBox cbListDashboard;
    }
}