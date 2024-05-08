using Examination_System.Managers;
using Examination_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Examination_System
{
    public partial class StudSolveExam : UserControl
    {
        int exam_no;
        int i = 0;

        int current_correct_answ;
        string current_correct_answ_str;
        QuestionsBank current_ques = new();

        public StudSolveExam(int _exam_no)
        {

            InitializeComponent();
            exam_no = _exam_no;
            StudentsManager.get_Exam_Questions(exam_no);
            OptionsPanel.Visible = false;
            this.sbmtBtn.Text = "Start";


        }


        private void StudSolveExam_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            this.sbmtBtn.Text = "Next";
            this.Qlbl.Text = $"Question Number {++i}";

            if (i >= StudentsManager.tmp_questions.Count) i = StudentsManager.tmp_questions.Count - 1;

            if (i < StudentsManager.tmp_questions.Count)
            {

                current_ques = StudentsManager.tmp_questions[i];
                this.QContentTxtBx.Text = current_ques.Content;
                List<Answer> answ = StudentsManager.get_answer_for_ques(current_ques.QuestionId);

                if (current_ques.Type == "MCQ")
                {
                    OptionsPanel.Visible = true;

                    this.CrctAnsCombo.Items.Clear();
                    this.Opt1TxtBx.Text = answ[0].Content;
                    this.Opt2TxtBx.Text = answ[1].Content;
                    this.Opt3TxtBx.Text = answ[2].Content;
                    this.Opt4TxtBx.Text = answ[3].Content;

                    this.CrctAnsCombo.Items.Add("Option 1");
                    this.CrctAnsCombo.Items.Add("Option 2");
                    this.CrctAnsCombo.Items.Add("Option 3");
                    this.CrctAnsCombo.Items.Add("Option 4");

                    if (answ[0].IsCorrect) current_correct_answ = 1;
                    else if (answ[1].IsCorrect) current_correct_answ = 2;
                    else if (answ[2].IsCorrect) current_correct_answ = 3;
                    else if (answ[3].IsCorrect) current_correct_answ = 4;

                }

                else
                {
                    OptionsPanel.Visible = false;

                    this.CrctAnsCombo.Items.Clear();


                    this.CrctAnsCombo.Items.Add("True");
                    this.CrctAnsCombo.Items.Add("False");

                    if (answ[0].IsCorrect) current_correct_answ_str = answ[1].Content;

                    else if (answ[1].IsCorrect) current_correct_answ_str = answ[1].Content;

                }
            }


        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Qlbl.Text = $"Question Number {--i}";
            if (i < 1) i = 1;

            if (i < StudentsManager.tmp_questions.Count && i > 0)
            {
                current_ques = StudentsManager.tmp_questions[i];
                this.QContentTxtBx.Text = current_ques.Content;
                List<Answer> answ = StudentsManager.get_answer_for_ques(current_ques.QuestionId);

                if (current_ques.Type == "MCQ")
                {
                    OptionsPanel.Visible = true;

                    this.Opt1TxtBx.Text = answ[0].Content;
                    this.Opt2TxtBx.Text = answ[1].Content;
                    this.Opt3TxtBx.Text = answ[2].Content;
                    this.Opt4TxtBx.Text = answ[3].Content;

                    this.CrctAnsCombo.Items.Add("Option 1");
                    this.CrctAnsCombo.Items.Add("Option 2");
                    this.CrctAnsCombo.Items.Add("Option 3");
                    this.CrctAnsCombo.Items.Add("Option 4");

                    if (answ[0].IsCorrect) current_correct_answ = 1;
                    else if (answ[1].IsCorrect) current_correct_answ = 2;
                    else if (answ[2].IsCorrect) current_correct_answ = 3;
                    else if (answ[3].IsCorrect) current_correct_answ = 4;

                }

                else
                {
                    OptionsPanel.Visible = false;



                    this.CrctAnsCombo.Items.Add("True");
                    this.CrctAnsCombo.Items.Add("False");

                    if (answ[0].IsCorrect) current_correct_answ_str = answ[1].Content;

                    else if (answ[1].IsCorrect) current_correct_answ_str = answ[1].Content;

                }

            }
        }

        private void subQues_Click(object sender, EventArgs e)
        {
            if (current_ques.Type == "MCQ") {
                int? grade=0;
                string choice = this.CrctAnsCombo.Text;
                int choice_int = 0;
                if (choice == "Option 1") choice_int = 1;
                if (choice == "Option 2") choice_int = 2;
                if (choice == "Option 3") choice_int = 3;
                if (choice == "Option 4") choice_int = 4;

                if (choice_int == current_correct_answ) grade = current_ques.Points;

                StudentsManager.insert_answer_mcq(current_ques.QuestionId,LoginManager.UserTypeID,exam_no, grade, choice);

                success succ = new("EEEEE");
                this.Controls.Add(succ);
                succ.BringToFront();

                if (i == StudentsManager.tmp_questions.Count - 1)
                {
                    subQues.Text = "Finish";
                }

                else { 
                    subQues.Text = "Answer";

                }
            }

            ///-----------------------------------------------
            ///
            if (current_ques.Type == "TF")
            {
                int? grade = 0;
                string choice = this.CrctAnsCombo.Text;
                int choice_int = 0;
                if (choice == "True") choice_int = 1;
                if (choice == "False") choice_int = 0;
                
                if (choice_int == current_correct_answ) grade = current_ques.Points;

                StudentsManager.insert_answer_tf(current_ques.QuestionId, LoginManager.UserTypeID, exam_no, grade, choice);

                success succ = new("EEEEE");
                this.Controls.Add(succ);
                succ.BringToFront();

                if (i == StudentsManager.tmp_questions.Count - 1)
                {
                    subQues.Text = "Finish";
                }

                else
                {
                    subQues.Text = "Answer";

                }
            }

        }
    }
}
