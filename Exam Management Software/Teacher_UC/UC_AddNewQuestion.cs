﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Management_Software.Teacher_UC
{
    public partial class UC_AddNewQuestion : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 questionNo = 1;

        public UC_AddNewQuestion()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddNewQuestion_Load(object sender, EventArgs e)
        {
            query = "select max(qSet) from questions";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString()!="")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtSet.Text = (id+1).ToString();
            }
            else
            {
                txtSet.Text = "1";
            }
            questionLabel.Text = questionNo.ToString();
            labelNotFound.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String qSet = txtSet.Text;
            String qNo = questionNo.ToString();
            String question = txtQuestion.Text;
            String option1 = txtOption1.Text;
            String option2 = txtOption2.Text;
            String option3 = txtOption3.Text;
            String option4 = txtOption4.Text;
            String ans = txtAnswer.Text;

            query = "insert into questions (qSet,qNo,question,optionA,optionB,optionC,optionD,ans) values ('"+qSet+"','"+qNo+"','"+question+"','"+option1+"','"+option2+"','"+option3+"','"+option4+"','"+ans+"')";
            fn.setData(query, "Question Added");

            //clearAll();
            questionNo++;
            questionLabel.Text = questionNo.ToString();
        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Unsave Data will be lost!!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Set will be changed.","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtSet.Text = (Int64.Parse(txtSet.Text.ToString()) + 1).ToString();
                questionLabel.Text = "1";
            }
        }

        private void txtSet_TextChanged(object sender, EventArgs e)
        {
            if(txtSet.Text != "")
            {
                clearAll();
                query = "select qNo from questions where qSet = '" + txtSet.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    questionLabel.Text = (ds.Tables[0].Rows.Count +1).ToString();
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                    labelNotFound.Visible = false;
                }
                else
                {
                    questionLabel.Text = "1";
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                    labelNotFound.Visible = true;
                }
            }
        }
    }
}
