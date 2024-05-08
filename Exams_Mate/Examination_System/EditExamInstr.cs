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

namespace Examination_System
{
    public partial class EditExamInstr : UserControl
    {
        public EditExamInstr()
        {
            InitializeComponent();
        }

        private void comboBoxExmNum_Click(object sender, EventArgs e)
        {
            this.comboBoxExmNum.Items.Clear();
            var res = InstructorsManager.Get_Instructor_Exams(LoginManager.UserTypeID);

            foreach (var item in res)
            {
                this.comboBoxExmNum.Items.Add(item.exam_no);
            }
        }

        private void EditExamInstr_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxExmNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Exam exm = InstructorsManager.Instructor_Exams.FirstOrDefault(item => item.exam_no == int.Parse(this.comboBoxExmNum.Text));
            this.numericMinutes.Value = (decimal)exm.Duration;
            this.numericGrade.Value = (decimal)exm.PassingGrade;
            if (exm.State == "Active") this.actvRad.Checked = true;
            else this.ntActiveRad.Checked = true;
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            int exm_num = int.Parse(this.comboBoxExmNum.Text);
            int duration = (int)this.numericMinutes.Value;
            int grade = (int)this.numericGrade.Value;
            string state = this.actvRad.Checked ? "Active" : "Ended";

            bool res = InstructorsManager.Edit_Exam(exm_num, duration, state, grade);
            if (res)
            {
                success succ = new("Edited");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            bool res = InstructorsManager.delete_exam(int.Parse(this.comboBoxExmNum.Text));
            if (res) {
                success succ = new("Deleted");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
        }
    }
}
