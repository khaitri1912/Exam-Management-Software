﻿namespace Exam_Management_Software
{
    partial class Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewDeleteQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_ViewDeleteQuestion1 = new Exam_Management_Software.Teacher_UC.UC_ViewDeleteQuestion();
            this.uC_UpdateQuestion1 = new Exam_Management_Software.Teacher_UC.UC_UpdateQuestion();
            this.uC_AddNewQuestion1 = new Exam_Management_Software.Teacher_UC.UC_AddNewQuestion();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.btnViewDeleteQuestions);
            this.panel1.Controls.Add(this.btnUpdateQuestion);
            this.panel1.Controls.Add(this.btnAddNewQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExit.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExit.Location = new System.Drawing.Point(75, 688);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.LimeGreen;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(5, 582);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(263, 45);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "Log Out";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnViewDeleteQuestions
            // 
            this.btnViewDeleteQuestions.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewDeleteQuestions.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.CheckedState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnViewDeleteQuestions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDeleteQuestions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDeleteQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDeleteQuestions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDeleteQuestions.FillColor = System.Drawing.Color.LimeGreen;
            this.btnViewDeleteQuestions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeleteQuestions.ForeColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestions.Location = new System.Drawing.Point(5, 511);
            this.btnViewDeleteQuestions.Name = "btnViewDeleteQuestions";
            this.btnViewDeleteQuestions.Size = new System.Drawing.Size(263, 56);
            this.btnViewDeleteQuestions.TabIndex = 4;
            this.btnViewDeleteQuestions.Text = "View and Delete Questions";
            this.btnViewDeleteQuestions.Click += new System.EventHandler(this.btnViewDeleteQuestions_Click);
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateQuestion.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.CheckedState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateQuestion.FillColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.Location = new System.Drawing.Point(5, 448);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(263, 45);
            this.btnUpdateQuestion.TabIndex = 3;
            this.btnUpdateQuestion.Text = "Update Question";
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewQuestion.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.CheckedState.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewQuestion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuestion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewQuestion.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.Location = new System.Drawing.Point(5, 384);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(263, 45);
            this.btnAddNewQuestion.TabIndex = 2;
            this.btnAddNewQuestion.Text = "Add New Question";
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher";
            this.label1.UseMnemonic = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 221);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.uC_ViewDeleteQuestion1);
            this.panel2.Controls.Add(this.uC_UpdateQuestion1);
            this.panel2.Controls.Add(this.uC_AddNewQuestion1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(274, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 768);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // uC_ViewDeleteQuestion1
            // 
            this.uC_ViewDeleteQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_ViewDeleteQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewDeleteQuestion1.Name = "uC_ViewDeleteQuestion1";
            this.uC_ViewDeleteQuestion1.Size = new System.Drawing.Size(1104, 768);
            this.uC_ViewDeleteQuestion1.TabIndex = 3;
            // 
            // uC_UpdateQuestion1
            // 
            this.uC_UpdateQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateQuestion1.Name = "uC_UpdateQuestion1";
            this.uC_UpdateQuestion1.Size = new System.Drawing.Size(1104, 768);
            this.uC_UpdateQuestion1.TabIndex = 2;
            // 
            // uC_AddNewQuestion1
            // 
            this.uC_AddNewQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_AddNewQuestion1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddNewQuestion1.Name = "uC_AddNewQuestion1";
            this.uC_AddNewQuestion1.Size = new System.Drawing.Size(1101, 768);
            this.uC_AddNewQuestion1.TabIndex = 1;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewQuestion;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnViewDeleteQuestions;
        private Guna.UI2.WinForms.Guna2Button btnUpdateQuestion;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Teacher_UC.UC_AddNewQuestion uC_AddNewQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Teacher_UC.UC_UpdateQuestion uC_UpdateQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Teacher_UC.UC_ViewDeleteQuestion uC_ViewDeleteQuestion1;
    }
}