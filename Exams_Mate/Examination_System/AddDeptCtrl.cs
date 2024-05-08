using Examination_System.Managers;
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
    public partial class AddDeptCtrl : UserControl
    {
        public AddDeptCtrl()
        {
            InitializeComponent();
        }

        private void AddDeptCtrl_Load(object sender, EventArgs e)
        {
            Load_mngr_combo();
        }

        private void Load_mngr_combo()
        {

            var res = InstructorsManager.Get_All_Instructor();

            foreach (var item in res)
            {
                string name = item.Fname + " " + item.Lname;
                this.mngrComboBx.Items.Add(name);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string dept_name = this.DeptNameTxtBox.Text;
            string descrip = this.deptDescripTxtBx.Text;
            string[] name = this.mngrComboBx.Text.Split(" ");
            int mngr_id = InstructorsManager.All_Instructors.FirstOrDefault(item => item.Fname == name[0] && item.Lname == name[1]).InsId;

            var res = InstructorsManager.add_dept(dept_name , mngr_id, descrip);

            if (res) {
                success succ = new("Added");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
        }
    }
}
