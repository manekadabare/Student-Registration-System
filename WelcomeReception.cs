using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_System
{
    public partial class WelcomeReception : Form
    {
        public WelcomeReception()
        {
            InitializeComponent();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBatchAdmin nba = new NewBatchAdmin();
            nba.MdiParent = this;
            nba.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCourseAdmin nca = new NewCourseAdmin();
            nca.MdiParent = this;
            nca.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudentAdmin nsa = new NewStudentAdmin();
            nsa.MdiParent = this;
            nsa.Show();
        }

        private void batchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewBatchAdmin vba = new ViewBatchAdmin();
            vba.MdiParent = this;
            vba.Show();
        }

        private void courseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCourseAdmin vca = new ViewCourseAdmin();
            vca.MdiParent = this;
            vca.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewStudentAdmin vsa = new ViewStudentAdmin();
            vsa.MdiParent = this;
            vsa.Show();
        }
    }
}
