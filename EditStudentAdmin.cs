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
    public partial class EditStudentAdmin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\HomePC\\Desktop\\Project - Student Registration System\\Student Registration System\\Student Registration System\\Student.mdf\";Integrated Security=True");
        public EditStudentAdmin()
        {
            InitializeComponent();
        }

        private void EditStudentAdmin_Load(object sender, EventArgs e)
        {
            label3.ResetText();
            getstdid();
        }
        public void getstdid()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT StudentID FROM [studentdetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList stdids = new ArrayList();
                while (reader.Read())
                {
                   stdids.Add(reader[0].ToString());
                }
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(stdids.ToArray());
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox1.Text = "";
            textBox7.Text = "";
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT StudentName, DateofBirth, BatchID, NIC FROM [studentdetails] WHERE StudentID = " + int.Parse(comboBox3.Text) + "", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList name = new ArrayList();
                string dob = "";
                string batchid = "";
                string nic = "";
                while (reader.Read())
                {
                    name.Add(reader[0].ToString());
                    dob = reader[1].ToString();
                    batchid = reader[2].ToString();
                    nic = reader[3].ToString();
                }
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(name.ToArray());
                comboBox1.SelectedIndex = 0;
                textBox7.Text = dob.ToString();
                textBox1.Text = batchid.ToString();
                textBox2.Text = nic.ToString();
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "" || comboBox1.Text == "" || textBox7.Text == ""|| textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Select a Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();
                    string name = comboBox1.Text;
                    string dob = textBox7.Text;
                    string batchid = textBox1.Text;
                    string nic = textBox2.Text;
                    SqlCommand command = new SqlCommand("UPDATE studentdetails SET StudentName = '" + name + "', DateofBirth = '" + dob + "', BatchID = '"+batchid+"', NIC = '"+nic+"' WHERE StudentID = " + int.Parse(comboBox3.Text) + "", connection);
                    command.ExecuteNonQuery();
                    label3.Text = "Updated!";
                    comboBox3.Text = "";
                    textBox1.Text = "";
                    comboBox1.Text = "";
                    textBox7.Text = "";
                    textBox2.Text = "";
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        }
    }

