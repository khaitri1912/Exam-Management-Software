using Exam_Management_Software.Teacher_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Management_Software
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = false;
            uC_UpdateQuestion1.Visible = false;
            uC_ViewDeleteQuestion1.Visible = false;
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = true;
            uC_AddNewQuestion1.BringToFront();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            uC_UpdateQuestion1.Visible = true;
            uC_UpdateQuestion1.BringToFront();
        }

        private void btnViewDeleteQuestions_Click(object sender, EventArgs e)
        {
            uC_ViewDeleteQuestion1.Visible=true;
            uC_ViewDeleteQuestion1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
