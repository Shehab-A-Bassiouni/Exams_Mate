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
    public partial class Manage : UserControl
    {

        public Manage()
        {
            InitializeComponent();

        }

        private void mngCrsBtn_Click(object sender, EventArgs e)
        {
            manageCourseInstr manageCourseInstr = new();
            this.Controls.Add(manageCourseInstr);
            manageCourseInstr.BringToFront();
            manageCourseInstr.Visible = true;

        }



        private void Manage_Load(object sender, EventArgs e)
        {
        }



        private void mngExamBtn_Click(object sender, EventArgs e)
        {
            EditExamInstr editExamInstr = new();
            this.Controls.Add(editExamInstr);
            editExamInstr.BringToFront();
            editExamInstr.Visible = true;
        }

        private void mngDeptbtn_Click(object sender, EventArgs e)
        {
            ManageDeptInstr manageDeptInstr = new();
            this.Controls.Add(manageDeptInstr);
            manageDeptInstr.BringToFront();
            manageDeptInstr.Visible = true;
        }

        private void mngQues_Click(object sender, EventArgs e)
        {
            mngQuesInstr mngQuesInstr = new();
            this.Controls.Add(mngQuesInstr);
            mngQuesInstr.BringToFront();
            mngQuesInstr.Visible = true;
        }
    }
}
