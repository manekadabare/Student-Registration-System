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
    public partial class WelcomeAdmin : Form
    {
        public WelcomeAdmin()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void batchToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NewBatchAdmin nba = new NewBatchAdmin();
            nba.MdiParent = this;
            nba.Show();
        }

        private void courseToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NewCourseAdmin nca = new NewCourseAdmin();
            nca.MdiParent = this;
            nca.Show();
        }

        private void studentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NewStudentAdmin nsa = new NewStudentAdmin();
            nsa.MdiParent = this;
            nsa.Show();
        }

        private void WelcomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void batchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditBatchAdmin eba = new EditBatchAdmin();
            eba.MdiParent = this;
            eba.Show();
        }

        private void courseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditCourseAdmin eca = new EditCourseAdmin();
            eca.MdiParent = this;
            eca.Show();
        }

        private void studentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditStudentAdmin esa = new EditStudentAdmin();
            esa.MdiParent = this;
            esa.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewStudentAdmin vsa = new ViewStudentAdmin();
            vsa.MdiParent = this;
            vsa.Show();
        }

        private void courseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCourseAdmin vca = new ViewCourseAdmin();
            vca.MdiParent = this;
            vca.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void batchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewBatchAdmin vba = new ViewBatchAdmin();
            vba.MdiParent = this;
            vba.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudentAdmin dsa = new DeleteStudentAdmin();
            dsa.MdiParent = this;
            dsa.Show();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBatchAdmin dba = new DeleteBatchAdmin();
            dba.MdiParent = this;
            dba.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCourseAdmin dca = new DeleteCourseAdmin();
            dca.MdiParent = this;
            dca.Show();
        }
    }
}
