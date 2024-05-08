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
    public partial class ManageDeptInstr : UserControl
    {
        public ManageDeptInstr()
        {
            InitializeComponent();
        }

        private void DeptComboBx_Click(object sender, EventArgs e)
        {
            this.DeptComboBx.Items.Clear();
            var res = InstructorsManager.Get_All_Depts();

            foreach (var item in res)
            {
                this.DeptComboBx.Items.Add(item.DeptName);
            }
        }

        private void mngrComboBx_Click(object sender, EventArgs e)
        {
            this.mngrComboBx.Items.Clear();
            var res = InstructorsManager.Get_All_Instructor();

            foreach (var item in res)
            {
                string name = item.Fname + " " + item.Lname;
                this.mngrComboBx.Items.Add(name);
            }
        }

        private void DeptComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {

            Department? dept = InstructorsManager.Depts.FirstOrDefault(item => item.DeptName == this.DeptComboBx.Text);

            int? mngrId = dept?.MgrId;

            string? fname = InstructorsManager.All_Instructors.FirstOrDefault(item => item.InsId == mngrId)?.Fname;
            string? lname = InstructorsManager.All_Instructors.FirstOrDefault(item => item.InsId == mngrId)?.Lname;

            string? FullName = fname + " " + lname;

            this.mngrComboBx.Text = FullName;
            this.DeptNameTxtBox.Text = dept.DeptName;
            this.deptDescripTxtBx.Text = dept.Description;

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            int dept_id = InstructorsManager.Depts.FirstOrDefault(item => item.DeptName == this.DeptComboBx.Text).DeptId;
            string dept_name = this.DeptComboBx.Text;
            string descrip = this.deptDescripTxtBx.Text;
            string[] mgr_name_split = this.mngrComboBx.Text.Split(" ");

            int mgr_id = InstructorsManager.All_Instructors.FirstOrDefault(item => item.Fname == mgr_name_split[0] && item.Lname == mgr_name_split[1]).InsId;
            bool res = InstructorsManager.edit_dept(dept_id, dept_name, descrip, mgr_id);

            if (res)
            {
                success succ = new("Edited");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

            int dept_id = InstructorsManager.Depts.FirstOrDefault(item => item.DeptName == this.DeptComboBx.Text).DeptId;

            bool res = InstructorsManager.delete_dept(dept_id);

            if (res)
            {
                success succ = new("Deleted");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
        }
    }
}
