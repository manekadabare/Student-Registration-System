namespace Student_Registration_System
{
    partial class WelcomeLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeLecturer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchToolStripMenuItem1,
            this.courseToolStripMenuItem1,
            this.studentToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // batchToolStripMenuItem1
            // 
            this.batchToolStripMenuItem1.Name = "batchToolStripMenuItem1";
            this.batchToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.batchToolStripMenuItem1.Text = "Batch";
            this.batchToolStripMenuItem1.Click += new System.EventHandler(this.batchToolStripMenuItem1_Click);
            // 
            // courseToolStripMenuItem1
            // 
            this.courseToolStripMenuItem1.Name = "courseToolStripMenuItem1";
            this.courseToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.courseToolStripMenuItem1.Text = "Course";
            this.courseToolStripMenuItem1.Click += new System.EventHandler(this.courseToolStripMenuItem1_Click);
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // WelcomeLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 632);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WelcomeLecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration System";
            this.Load += new System.EventHandler(this.WelcomeLecturer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
    }
}