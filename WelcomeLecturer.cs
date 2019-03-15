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
    public partial class WelcomeLecturer : Form
    {
        public WelcomeLecturer()
        {
            InitializeComponent();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private void WelcomeLecturer_Load(object sender, EventArgs e)
        {

        }
    }
}
