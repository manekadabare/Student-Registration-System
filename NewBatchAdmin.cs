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
    public partial class NewBatchAdmin : Form
    {
        int batchid;
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\HomePC\\Desktop\\Project - Student Registration System\\Student Registration System\\Student Registration System\\Student.mdf\";Integrated Security=True");
        public NewBatchAdmin()
        {
            InitializeComponent();
        }

        private void NewBatchAdmin_Load(object sender, EventArgs e)
        {
            getcourseid();
            label10.ResetText();
            try
            {
            string batchid = "0";
                int oldbatchid, newbatchid;
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MAX(BatchID) FROM [batchdetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    batchid = reader[0].ToString();
                }
                oldbatchid = int.Parse(batchid.ToString());
                newbatchid = oldbatchid + 1;
                textBox1.Text = newbatchid.ToString();
               
            }
            
            finally
            {
                connection.Close();
            }
        }
        public void getcourseid()
        {
            try
            {
                ArrayList courseids = new ArrayList();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CourseID FROM [coursedetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            comboBox3.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            comboBox4.Text = "";
            comboBox2.Items.Clear();
            getcourseid();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CourseName, Duration, Lecturer FROM [coursedetails] WHERE CourseID = " + int.Parse(comboBox2.Text) + "", connection);
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
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(coursename.ToArray());
                comboBox3.SelectedIndex = 0;
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
            if (textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox4.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please Enter All the Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    
                    batchid = int.Parse(textBox1.Text);
                    string startingdate = textBox2.Text;
                    string endingdate = textBox3.Text;
                    string day = textBox4.Text;
                    string time = textBox5.Text;
                    string courseid = comboBox2.Text;
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [batchdetails]  VALUES ("+batchid+", '" + startingdate + "', '" + endingdate + "', '" + day + "', '" + time + "', " + int.Parse(courseid) + ")", connection);
                    command.ExecuteNonQuery();
                    label10.Text = "Batch Added!";
                    int oldbatchid = int.Parse(textBox1.Text);
                    int newbatchid = oldbatchid + 1;
                    textBox1.Text = newbatchid.ToString();
                    textBox7.Text = "";
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox5.Text = "";
                    comboBox3.Text = "";
                    comboBox2.Text = "";
                    textBox4.Text = "";
                    comboBox4.Text = "";
                    comboBox2.Items.Clear();
                   


                }
                
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
       
