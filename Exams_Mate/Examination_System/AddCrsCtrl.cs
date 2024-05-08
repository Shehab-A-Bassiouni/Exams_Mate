using Examination_System.Managers;
using Examination_System.Models;
using Examination_System.StoredProcModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI_Exam_SystemContext = Examination_System.Models.ITI_Exam_SystemContext;

namespace Examination_System
{
    public partial class AddCrsCtrl : UserControl
    {
        success succ;

        ITI_Exam_SystemContext context = new();

        public AddCrsCtrl()
        {
            InitializeComponent();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {


            string crs_name = this.txtCrsName.Text;
            string state = this.actvRad.Checked ? "Active" : "Not Active";
            string descrip = this.crsDescripTxtBx.Text;
            int hours = (int)this.numericHours.Value;
            int total_grade = (int)this.numericGrades.Value;
            int dept_id = InstructorsManager.Depts.FirstOrDefault(item => item.DeptName == this.deptComboBox.Text).DeptId;
            int inst_id = LoginManager.UserTypeID;

            bool res = InstructorsManager.Add_Crs(crs_name, state, descrip, hours, total_grade, dept_id, inst_id);

            if (res)
            {
                succ = new("Added");
                this.Controls.Add(succ);
                succ.BringToFront();
                InstructorsManager.Get_Instructor_Courses();
            }

        }

        private void AddCrsCtrl_Load(object sender, EventArgs e)
        {
            load_dept_combo();
            this.crsDescripTxtBx.GotFocus += descrip_GotFocus;
            this.crsDescripTxtBx.LostFocus += descrip_LostFocus;
        }

        private void load_dept_combo() {
            var depts = InstructorsManager.Get_All_Depts();

            foreach (var item in depts) {
                this.deptComboBox.Items.Add(item.DeptName);
            }
        }

        private void descrip_GotFocus(object sender, EventArgs e) {
            if (this.crsDescripTxtBx.Text == "Enter Course Description..") {
                this.crsDescripTxtBx.Text = "";
            }
        }

        private void descrip_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.crsDescripTxtBx.Text)) {
                this.crsDescripTxtBx.Text = "Enter Course Description..";
            }
        }
    }
}
