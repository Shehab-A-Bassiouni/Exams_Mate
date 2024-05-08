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
    public partial class manageCourseInstr : UserControl
    {
        public manageCourseInstr()
        {
            InitializeComponent();
        }

        private void manageCourseInstr_Load(object sender, EventArgs e)
        {

        }



        private void comboBoxCrs_Click(object sender, EventArgs e)
        {
            this.comboBoxCrs.Items.Clear();
            var res = InstructorsManager.Get_Instructor_Courses();

            foreach (var item in res)
            {
                this.comboBoxCrs.Items.Add(item.CrsName);
            }
        }

        private void comboBoxCrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course course = InstructorsManager.Instructor_Courses.FirstOrDefault(item => item.CrsName == this.comboBoxCrs.Text);
            this.CrsIdTxtBx.Text = course.CrsId.ToString();
            this.txtCrsName.Text = course.CrsName;
            if (course.State == "Active") this.actvRad.Checked = true;
            else this.ntActiveRad.Checked = true;
            this.numericHours.Value = (decimal)course.Hours;
            this.numericGrades.Value = (decimal)course.TotalGrade;
            this.crsDescripTxtBx.Text = course.Description;
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            int crs_id = int.Parse(this.CrsIdTxtBx.Text);
            string crs_name = this.txtCrsName.Text;
            string state = this.actvRad.Checked ? "Active" : "InActive";
            string descrip = this.crsDescripTxtBx.Text;
            int hours = (int)this.numericHours.Value;
            int total_grade = (int)this.numericGrades.Value;
            bool res = InstructorsManager.Edit_Course(crs_id, crs_name, state, descrip, hours, total_grade);
            if (res)
            {
                success succ = new("Edited");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            Course crs = InstructorsManager.Instructor_Courses.FirstOrDefault(item => item.CrsName == this.comboBoxCrs.Text);
            bool res = InstructorsManager.delete_course(crs.CrsId);
            if (res)
            {
                success succ = new("Deleted");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
        }


    }
}
