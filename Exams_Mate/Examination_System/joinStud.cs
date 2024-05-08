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
    public partial class joinStud : UserControl
    {
        public joinStud()
        {
            InitializeComponent();
        }

        private void joinStud_Load(object sender, EventArgs e)
        {
            
        }

     

        private void comboBoxCrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course crs = StudentsManager.All_Courses.FirstOrDefault(item => item.CrsName == this.comboBoxCrs.Text);
            this.crsNameTxtBx.Text = crs.CrsName;
            this.crsDescripTxtbx.Text = crs.Description;
            this.CrsTotalGradeTxtBx.Text = crs.TotalGrade.ToString();
            this.CrsHoursTxtBx.Text = crs.Hours.ToString();
            this.CrsInstrTxtBx.Text = InstructorsManager.get_instructors_by_crs_id(crs.CrsId);

        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            Course crs = StudentsManager.All_Courses.FirstOrDefault(item => item.CrsName == this.comboBoxCrs.Text);

            bool res = StudentsManager.join_crs(crs.CrsId, LoginManager.UserTypeID);

            if (res) {

                success succ = new("Joined");
                this.Controls.Add(succ);
                succ.BringToFront();
            }
            
            
        }

        private void comboBoxCrs_Click(object sender, EventArgs e)
        {
            this.comboBoxCrs.Items.Clear();

            StudentsManager.Get_All_Crs();

            var res = StudentsManager.all_stud_crcs();

            List<Models.Course> crcsNotIn = new();
            List<int> crcsIn = new();

            foreach (var item in res) {
                if (item.StdId == LoginManager.UserTypeID ) {
                    crcsIn.Add(item.CrsId);
                }
            }

            foreach (var item in StudentsManager.All_Courses) {
                if (!crcsIn.Contains(item.CrsId))
                    crcsNotIn.Add(item);
            }

            foreach (var item in crcsNotIn) {
                this.comboBoxCrs.Items.Add(item.CrsName);
            }
        }
    }
}
