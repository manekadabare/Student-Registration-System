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
using System.Collections;

namespace Student_Registration_System
{
    public partial class ViewStudentAdmin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\HomePC\\Desktop\\Project - Student Registration System\\Student Registration System\\Student Registration System\\Student.mdf\";Integrated Security=True");
        public ViewStudentAdmin()
        {
            InitializeComponent();
        }

        private void ViewStudentAdmin_Load(object sender, EventArgs e)
        {
            getbatchids();
            getstudentid();
            getstudentnames();
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT sd.StudentID, sd.StudentName, sd.DateofBirth , sd.BatchID, sd.NIC, bd.StartingDate, bd.EndingDate, bd.Day, bd.Time, bd.CourseID, cd.CourseName, cd.Duration, cd.Lecturer FROM [studentdetails] AS sd, [batchdetails] AS bd, [coursedetails] AS cd WHERE sd.BatchID = bd.BatchID AND bd.CourseID = cd.CourseID", connection);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[1].Width = 190;
                dataGridView1.Columns[10].Width = 250;
                dataGridView1.Columns[12].Width = 150;
                dataGridView1.Columns[0].HeaderText = "Student ID";
                dataGridView1.Columns[1].HeaderText = "Student Name";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Date of Birth";

                dataGridView1.Columns[3].HeaderText = "Batch ID";
                dataGridView1.Columns[0].Frozen = true;
                dataGridView1.Columns[1].Frozen = true;
            }
            finally
            {
                connection.Close();
            }
        }
        public void getstudentid()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT StudentID FROM [studentdetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList studentids = new ArrayList();
                while (reader.Read())
                {
                    studentids.Add(reader[0].ToString());
                }
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(studentids.ToArray());


            }
            finally
            {
                connection.Close();
            }
        }
        public void getbatchids()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT BatchID FROM [batchdetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList courseids = new ArrayList();
                while (reader.Read())
                {
                    courseids.Add(reader[0].ToString());
                }
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(courseids.ToArray());
            }
            finally
            {
                connection.Close();
            }
        }
        public void getstudentnames()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT StudentName FROM [studentdetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList studentnames = new ArrayList();
                while (reader.Read())
                {
                    studentnames.Add(reader[0].ToString());
                }
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(studentnames.ToArray());
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getbatchids();
            getstudentid();
            getstudentnames();
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox1.Text = "";
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT sd.StudentID, sd.StudentName, sd.DateofBirth , sd.BatchID, sd.NIC, bd.StartingDate, bd.EndingDate, bd.Day, bd.Time, bd.CourseID, cd.CourseName, cd.Duration, cd.Lecturer FROM [studentdetails] AS sd, [batchdetails] AS bd, [coursedetails] AS cd WHERE sd.BatchID = bd.BatchID AND bd.CourseID = cd.CourseID", connection);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[1].Width = 190;
                dataGridView1.Columns[10].Width = 250;
                dataGridView1.Columns[12].Width = 150;
                dataGridView1.Columns[0].HeaderText = "Student ID";
                dataGridView1.Columns[1].HeaderText = "Student Name";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Date of Birth";
                
                dataGridView1.Columns[4].HeaderText = "Batch ID";
                dataGridView1.Columns[0].Frozen = true;
                dataGridView1.Columns[1].Frozen = true;
            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT StudentName, BatchID FROM [studentdetails] WHERE StudentID = " + int.Parse(comboBox1.Text) + "", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList name = new ArrayList();
                ArrayList batchid = new ArrayList();
                while (reader.Read())
                {
                    name.Add(reader[0].ToString());
                    batchid.Add(reader[1].ToString());
                }
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(name.ToArray());
                comboBox3.SelectedIndex = 0;
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(batchid.ToArray());
                comboBox2.SelectedIndex = 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
