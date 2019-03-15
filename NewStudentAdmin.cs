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
    public partial class NewStudentAdmin : Form
    {
        string startingdate;
        string endingdate;
        string day;
        string time;
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\HomePC\\Desktop\\Project - Student Registration System\\Student Registration System\\Student Registration System\\Student.mdf\";Integrated Security=True");
        public NewStudentAdmin()
        {
            InitializeComponent();
            getbatchids();
        }

        private void NewStudentAdmin_Load(object sender, EventArgs e)
        {
            label5.ResetText();
            try
            {
                string studentid = "0";
                int oldstdid, newstdid;
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MAX (StudentID) FROM [studentdetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    studentid = reader[0].ToString();
                }
                oldstdid = int.Parse(studentid.ToString());
                newstdid = oldstdid + 1;
                textBox1.Text = newstdid.ToString();

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
                ArrayList batchids = new ArrayList();
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT BatchID FROM [batchdetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    batchids.Add(reader[0].ToString());
                }
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(batchids.ToArray());
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox8.Text = "";
            textBox2.Text = "";
            textBox9.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            textBox6.Text = "";
            label5.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox1.Text == "" || textBox4.Text == "" || comboBox1.Text == "" ||textBox9.Text == "" || textBox8.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please Enter All the Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int stdid = int.Parse(textBox1.Text);
                    int batchid = int.Parse(comboBox1.Text);
                    string name = textBox2.Text;
                    string dob = textBox3.Text;
                    string nic = textBox4.Text;

                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [studentdetails]  VALUES (" + stdid + ", '" + name + "', '" + dob + "',  " + batchid + ", '" + nic + "')", connection);
                    command.ExecuteNonQuery();
                    label5.Text = "Student Added!";
                    int oldstdid = int.Parse(textBox1.Text);
                    int newstdid = oldstdid + 1;
                    textBox1.Text = newstdid.ToString();

                    textBox3.Text = "";
                    textBox8.Text = "";
                    textBox2.Text = "";
                    textBox9.Text = "";
                    textBox7.Text = "";
                    comboBox1.Text = "";
                    textBox6.Text = "";
                    textBox4.Text = "";

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
                SqlCommand command = new SqlCommand("SELECT StartingDate, EndingDate, Day, Time FROM batchdetails WHERE BatchID = " + int.Parse(comboBox1.Text) + "", connection);
                SqlDataReader reader;

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    startingdate = reader[0].ToString();
                    endingdate = reader[1].ToString();
                    day = reader[2].ToString();
                    time = reader[3].ToString();
                }
                command.Dispose();
                connection.Close();
                textBox9.Text = startingdate;
                textBox8.Text = endingdate;
                textBox6.Text = day;
                textBox7.Text = time;
            }
            
        }
    }

