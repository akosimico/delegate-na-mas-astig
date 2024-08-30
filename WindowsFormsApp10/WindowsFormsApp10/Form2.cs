using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp10.Form1;

namespace WindowsFormsApp10
{
    public partial class Form2 : Form
    {

        private Student student;

        public Form2(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.Text = "First Name: " + student.FirstName;
            label2.Text = "Last Name: " + student.LastName;
            label3.Text = "Middle Name: " + student.MiddleName;
            label8.Text = "Address: " + student.Address;
            label5.Text = "Program: " + student.Program;
            label6.Text = "Age: " + student.Age.ToString();
            label7.Text = "Contact Number: " + student.ContactNo.ToString();
            label4.Text = "Student Number: " + student.StudentNo.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = guna2MessageDialog1.Show();

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = guna2MessageDialog2.Show();

            if (result == DialogResult.Yes)
            {

                guna2MessageDialog3.Show();
                this.Close();
            }
        }
    }
}
