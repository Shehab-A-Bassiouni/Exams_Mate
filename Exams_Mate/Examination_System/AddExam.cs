using Examination_System.Managers;
using Examination_System.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.AxHost;

namespace Examination_System
{

    public partial class AddExam : UserControl
    {
        success scc = new("Added");

        ITI_Exam_SystemContext Dbcontext = new();


        public AddExam()
        {
            InitializeComponent();
        }


        private void AddExam_Load(object sender, EventArgs e)
        {

        }

        private void load_crs_comboBox()
        {
            var Crs = InstructorsManager.Get_Instructor_Courses();

            foreach (var item in Crs)
            {
                comboBoxCrsID.Items.Add(item.CrsName);
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            int crsId = InstructorsManager.Instructor_Courses.FirstOrDefault(item => item.CrsName == this.comboBoxCrsID.Text).CrsId;
            int Duration = Convert.ToInt32(numericMinutes.Value);
            var Grade = Convert.ToInt32(numericGrade.Value);
            var MCQQues = Convert.ToInt32(numericMCQ.Value);
            var TFQues = Convert.ToInt32(numericTF.Value);

            bool res = InstructorsManager.Add_Instructor_Exam(Duration, Grade, crsId, MCQQues, TFQues);

            if (res == true)
            {
                this.Controls.Add(scc);
                scc.BringToFront();
            }
        }

        private void comboBoxCrsID_Click(object sender, EventArgs e)
        {
            this.comboBoxCrsID.Items.Clear();
            load_crs_comboBox();

        }
    }
}
