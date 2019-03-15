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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Admin";
            string password = "Admin@omc1!";
            string username1 = "Lecturer";
            string password1 = "Lecturer@omc2!";
            string username2 = "Reception";
            string password2 = "Reception@omc3!";
            if (textBox1.Text == username & textBox2.Text == password)
            {

                new WelcomeAdmin().Show();
                textBox1.Text = "";
                textBox2.Text = "";
                label3.Text = "";

            }
            else if (textBox1.Text == username1 & textBox2.Text == password1)
            {

                new WelcomeLecturer().Show();
                textBox1.Text = "";
                textBox2.Text = "";
                label3.Text = "";

            }
            else if (textBox1.Text == username2 & textBox2.Text == password2)
            {

                new WelcomeReception().Show();
                textBox1.Text = "";
                textBox2.Text = "";
                label3.Text = "";

            }


            else if (textBox1.Text == "" & textBox2.Text == "")
            {
                label3.Text = "Please Enter Your Username and Password!";
            }
            else
            {
                label3.Text = "Incorrect Username or Password!";
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            label3.ResetText();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
