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
    public partial class Form1 : Form
    {
        private Timer timer;
        private int displayTimeInSeconds = 2;


        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }


        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Timer sẽ được kích hoạt mỗi giây
            timer.Tick += Timer_Tick;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            displayTimeInSeconds--;

            if (displayTimeInSeconds <= 0)
            {
                timer.Stop();
                wrongLabel.Visible = false; // Ẩn label khi thời gian đã hết
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowHide.Checked )
            {
                txtPassword.PasswordChar = '\0';
                checkBoxShowHide.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "TeacherLinh" && txtPassword.Text == "TeacherLinh")
            {
                wrongLabel.Visible = false;
                Teacher te = new Teacher();
                te.Show();
                this.Hide();
            }
            else
            {
                wrongLabel.Visible=true;
                timer.Start();
            }
        }
    }
}
