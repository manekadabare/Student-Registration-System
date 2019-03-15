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
    public partial class EditCourseAdmin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\HomePC\\Desktop\\Project - Student Registration System\\Student Registration System\\Student Registration System\\Student.mdf\";Integrated Security=True");
        public EditCourseAdmin()
        {
            InitializeComponent();
            
        }

        private void EditCourseAdmin_Load(object sender, EventArgs e)
        {
            label3.ResetText();
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
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(courseids.ToArray());
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox1.Text = "";
            textBox7.Text = "";
            label3.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CourseName, Duration, Lecturer FROM [coursedetails] WHERE CourseID = " + int.Parse(comboBox3.Text) + "", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList coursename = new ArrayList();
                string duration = "";
                ArrayList lecturer = new ArrayList();
                while (reader.Read())
                {
                    coursename.Add(reader[0].ToString());
                    duration = reader[1].ToString();
                    lecturer.Add(reader[2].ToString());
                }
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(coursename.ToArray());
                comboBox1.SelectedIndex = 0;
                textBox7.Text = duration.ToString();
                comboBox4.Items.Clear();
                comboBox4.Items.AddRange(lecturer.ToArray());
                comboBox4.SelectedIndex = 0;
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "" || comboBox1.Text == "" || textBox7.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("Please Select a Course ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            try
            {
                connection.Open();
                string cname = comboBox1.Text;
                string duration = textBox7.Text;
                string lecturer = comboBox4.Text;
                SqlCommand command = new SqlCommand("UPDATE coursedetails SET CourseName = '" + cname + "', Duration = '" + duration + "', Lecturer = '" + lecturer + "' WHERE CourseID = " + int.Parse(comboBox3.Text) + "", connection);
                command.ExecuteNonQuery();
                label3.Text = "Updated!";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox1.Text = "";
                textBox7.Text = "";
            }
            finally
            {
                connection.Close();
            }
            }
        }
    }
}
