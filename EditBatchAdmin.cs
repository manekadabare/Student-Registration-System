﻿using System;
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
    public partial class EditBatchAdmin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\HomePC\\Desktop\\Project - Student Registration System\\Student Registration System\\Student Registration System\\Student.mdf\";Integrated Security=True");
        public EditBatchAdmin()
        {
            InitializeComponent();
            getbatchids();
        }

        private void EditBatchAdmin_Load(object sender, EventArgs e)
        {
            label6.ResetText();
        }
        public void getbatchids()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT BatchID FROM [batchdetails]", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                ArrayList batchids = new ArrayList();
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
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label6.Text = "";
            textBox1.Text = "";
     }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT StartingDate, EndingDate, Day, Time, CourseID FROM [batchdetails] WHERE BatchID = " + int.Parse(comboBox1.Text) + "", connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                string startingdate = "";
                string endingdate = "";
                string day = "";
                string time = "";
                string courseid = "";
                while (reader.Read())
                {
                    startingdate = reader[0].ToString();
                    endingdate = reader[1].ToString();
                    day = reader[2].ToString();
                    time = reader[3].ToString();
                    courseid = reader[4].ToString();
                }
                textBox2.Text = startingdate.ToString();
                textBox3.Text = endingdate.ToString();
                textBox4.Text = day.ToString();
                textBox5.Text = time.ToString();
                textBox1.Text = courseid.ToString();
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox1.Text == "") 
            {
            MessageBox.Show("Please Select a Batch ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            try
            {
                connection.Open();
                string startingdate = textBox2.Text;
                string endingdate = textBox3.Text;
                string day = textBox4.Text;
                string time = textBox5.Text;
                string courseid = textBox1.Text;
                SqlCommand command = new SqlCommand("UPDATE batchdetails SET StartingDate = '" + startingdate + "', EndingDate = '" + endingdate + "', Day = '" + day + "', Time = '" + time + "', CourseID = '"+courseid+"' WHERE BatchID = " + int.Parse(comboBox1.Text) + "", connection);
                command.ExecuteNonQuery();
                label6.Text = "Updated!";
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox1.Text = "";
            }
            finally
            {
                connection.Close();
            }
            }
        }
    }
}
