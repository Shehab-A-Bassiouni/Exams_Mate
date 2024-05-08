using Examination_System.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class mngQuesInstr : UserControl
    {
        public mngQuesInstr()
        {
            InitializeComponent();
        }

        private void CrsNameCombo_Click(object sender, EventArgs e)
        {
            InstructorsManager.Get_Instructor_Courses();
            this.CrsNameCombo.Items.Clear();

            var res = InstructorsManager.Instructor_Courses;

            foreach (var item in res)
            {
                this.CrsNameCombo.Items.Add(item.CrsName);
            }
        }

        private void QuesIdComboBx_Click(object sender, EventArgs e)
        {
            
            int? crs_id = InstructorsManager.Instructor_Courses.FirstOrDefault(item => item.CrsName == this.CrsNameCombo.Text)?.CrsId;
            var res = InstructorsManager.get_questions_by_crs(crs_id);

            this.QuesIdComboBx.Items.Clear();

            foreach (var item in res)
            {
                this.QuesIdComboBx.Items.Add(item.QuestionId);
            }



        }

        private void QuesIdComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Course? crs = InstructorsManager.Instructor_Courses.FirstOrDefault(item => item.CrsName == this.CrsNameCombo.Text);

            Models.QuestionsBank? ques_data = InstructorsManager.get_question_data_by_id(int.Parse(this.QuesIdComboBx.Text) , crs.CrsId);

            this.QContentTxtBx.Text = ques_data.Content;
            this.numericPoints.Value = (int)ques_data?.Points;

            this.CrctAnsCombo.Items.Clear();

            List<Models.Answer>? answers = InstructorsManager.get_answers_by_ques_id(ques_data.QuestionId);

            if (ques_data.Type == "MCQ")
            {
                this.OptionsPanel.Visible = true;

                this.Opt1TxtBx.Text = answers[0].Content;
                this.Opt2TxtBx.Text = answers[1].Content;
                this.Opt3TxtBx.Text = answers[2].Content;
                this.Opt4TxtBx.Text = answers[3].Content;

                string correct_ans = "";
                if (answers[0].IsCorrect) correct_ans = "Option 1";
                else if (answers[1].IsCorrect) correct_ans = "Option 2";
                else if (answers[2].IsCorrect) correct_ans = "Option 3";
                else if (answers[3].IsCorrect) correct_ans = "Option 4";

                this.CrctAnsCombo.Text = correct_ans;

                this.CrctAnsCombo.Items.Add("Option 1");
                this.CrctAnsCombo.Items.Add("Option 2");
                this.CrctAnsCombo.Items.Add("Option 3");
                this.CrctAnsCombo.Items.Add("Option 4");
            }
            else
            {
                this.OptionsPanel.Visible = false;
                this.CrctAnsCombo.Items.Add("True");
                this.CrctAnsCombo.Items.Add("False");

                if (answers[0].Content == "True" && answers[0].IsCorrect == true)
                    this.CrctAnsCombo.Text = "True";

                else if (answers[0].Content == "False" && answers[0].IsCorrect == true)
                    this.CrctAnsCombo.Text = "False";

                else if (answers[1].Content == "True" && answers[1].IsCorrect == true)
                    this.CrctAnsCombo.Text = "True";

                else if (answers[1].Content == "False" && answers[1].IsCorrect == true)
                    this.CrctAnsCombo.Text = "False";

            }
        }

        private void mngQuesInstr_Load(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Models.Course? crs = InstructorsManager.Instructor_Courses.FirstOrDefault(item => item.CrsName == this.CrsNameCombo.Text);
            Models.QuestionsBank? ques_data = InstructorsManager.get_question_data_by_id(int.Parse(this.QuesIdComboBx.Text) , crs.CrsId);


            if (ques_data.Type == "MCQ")
            {
                string content = this.QContentTxtBx.Text;
                int points = (int)this.numericPoints.Value;
                List<string> answ = new() { this.Opt1TxtBx.Text, this.Opt2TxtBx.Text, this.Opt3TxtBx.Text, this.Opt4TxtBx.Text };
                int crct = 0;
                if (this.CrctAnsCombo.Text == "Option 1")
                    crct = 1;

                else if (this.CrctAnsCombo.Text == "Option 2")
                    crct = 2;

                else if (this.CrctAnsCombo.Text == "Option 3")
                    crct = 3;

                else if (this.CrctAnsCombo.Text == "Option 4")
                    crct = 4;



                bool res = InstructorsManager.edit_mcq_ques(ques_data.QuestionId, content, points, answ, crct);

                if (res)
                {
                    success succ = new("Edited");
                    this.Controls.Add(succ);
                    succ.BringToFront();
                }
            }


            if (ques_data.Type == "TF")
            {
                string content = this.QContentTxtBx.Text;
                int points = (int)this.numericPoints.Value;
                List<string> answ = new() { "True" , "False" };
                int crct = 0;
                if (this.CrctAnsCombo.Text == "True")
                    crct = 1;

                else if (this.CrctAnsCombo.Text == "False")
                    crct = 0;


                bool res = InstructorsManager.edit_tf_ques(ques_data.QuestionId, content, points, answ, crct);

                if (res)
                {
                    success succ = new("Edited");
                    this.Controls.Add(succ);
                    succ.BringToFront();
                }
            }
            ClearDataInUserControl();
            this.Refresh();
            
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            var res = InstructorsManager.delete_ques_by_id(int.Parse(this.QuesIdComboBx.Text));
            if (res) {
                success succ = new("Deleted");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
            ClearDataInUserControl();
            this.Refresh();
        }

        private void ClearDataInUserControl()
        {
            QContentTxtBx.Text = string.Empty;
            Opt1TxtBx.Text = string.Empty;
            Opt2TxtBx.Text = string.Empty;
            Opt3TxtBx.Text = string.Empty;
            Opt4TxtBx.Text = string.Empty;
            numericPoints.Value = 0;
            CrctAnsCombo.Text = string.Empty;
            CrsNameCombo.Text = string.Empty;
            QuesIdComboBx.Text = string.Empty;
        }
    }
}
