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
    public partial class slvStud : UserControl
    {
        int exam_no;
        public slvStud()
        {
            InitializeComponent();
        }

        private void slvStud_Load(object sender, EventArgs e)
        {

        }

        private void crsComboBx_Click(object sender, EventArgs e)
        {
            this.crsComboBx.Items.Clear();
            List<int> crcs = StudentsManager.get_Stud_Crcs();

            foreach (var item in crcs)
            {
                string name = StudentsManager.All_Courses.FirstOrDefault(iter => iter.CrsId == item).CrsName;
                this.crsComboBx.Items.Add(name);
            }
        }

        private void crsComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {

            int crs_id = StudentsManager.All_Courses.FirstOrDefault(item => item.CrsName == this.crsComboBx.Text).CrsId;
            List<Exam> exams = StudentsManager.get_Exams(crs_id);


            foreach (var item in exams)
            {
                this.exmComboBx.Items.Add(item.exam_no);

            }
        }

        private void exmComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Exam exm = StudentsManager.get_exam_data(int.Parse(this.exmComboBx.Text));
            this.PassGradeTxtBx.Text = exm.PassingGrade.ToString();
            this.DurationTxtBx.Text = exm.Duration.ToString();

            exam_no = exm.exam_no;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudSolveExam slv = new(exam_no);
            this.Controls.Add(slv);
            slv.BringToFront();
        }

        private void exmComboBx_Click(object sender, EventArgs e)
        {

        }
    }
}
