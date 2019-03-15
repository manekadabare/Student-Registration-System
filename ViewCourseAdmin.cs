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
    public partial class ViewCourseAdmin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\HomePC\\Desktop\\Project - Student Registration System\\Student Registration System\\Student Registration System\\Student.mdf\";Integrated Security=True");
        public ViewCourseAdmin()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ViewCourseAdmin_Load(object sender, EventArgs e)
        {
            getcourseid();
        }
        public void getcourseid()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CourseID FROM [coursedetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList courseids = new ArrayList();
                while (reader.Read())
                {
                    courseids.Add(reader[0].ToString());
                }
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(courseids.ToArray());
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox7.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CourseName, Duration, Lecturer FROM [coursedetails] WHERE CourseID = " + int.Parse(comboBox1.Text) + "", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                string coursename = "";
                string duration = "";
                string lecturer = "";
                while (reader.Read())
                {
                    coursename = reader[0].ToString();
                    duration = reader[1].ToString();
                    lecturer = reader[2].ToString();
                }
                textBox1.Text = coursename.ToString();
                textBox7.Text = duration.ToString();
                textBox2.Text = lecturer.ToString();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
