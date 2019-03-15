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
    public partial class NewCourseAdmin : Form
    {
        int courseid;
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\HomePC\\Desktop\\Project - Student Registration System\\Student Registration System\\Student Registration System\\Student.mdf\";Integrated Security=True");
        public NewCourseAdmin()
        {
            InitializeComponent();
            getdetails();
        }

        private void NewCourseAdmin_Load(object sender, EventArgs e)
        {
             label2.ResetText();
            try
            {
                string cid = "0";
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MAX (CourseID) FROM [coursedetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cid = reader[0].ToString();
                }
                int oldcourseid = int.Parse(cid);
                int newcourseid = oldcourseid + 1;
                textBox1.Text = newcourseid.ToString();
            }
            finally
            {
                connection.Close();
            }
        }
        private void getdetails()
        {
            try
            {
                ArrayList coursenames = new ArrayList();
                ArrayList lecturers = new ArrayList();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CourseName, Lecturer FROM [coursedetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    coursenames.Add(reader[0].ToString());
                    lecturers.Add(reader[1].ToString());
                }
                comboBox3.Items.AddRange(coursenames.ToArray());
                comboBox4.Items.AddRange(lecturers.ToArray());
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             comboBox3.Text = "";
            textBox7.Text = "";
            comboBox4.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "" || textBox7.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("PLease enter all the Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    courseid = int.Parse(textBox1.Text);
                    string cname = comboBox3.Text;
                    string duration = textBox7.Text;
                    string lecturer = comboBox4.Text;
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [coursedetails] VALUES ("+courseid+", '" + cname + "' , '" + duration + "', '" + lecturer + "')", connection);
                    command.ExecuteNonQuery();
                    comboBox3.Text = "";
                    textBox7.Text = "";
                    comboBox4.Text = "";
                    label2.Text = "Course Added!";
                    int oldcourseid = int.Parse(textBox1.Text);
                    int newcourseid = oldcourseid + 1;
                    textBox1.Text = newcourseid.ToString();
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        }

        }
   