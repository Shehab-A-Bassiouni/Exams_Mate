using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;

namespace Examination_System
{
    public partial class Instructor : Form
    {

        bool mouseDown;
        Point lastLocation;
        public Instructor()
        {
            InitializeComponent();
            this.cpyright.Text = "Copyright \u00A9 DB Team 4\r\n";
            InstrHome instrHome = new();
            this.Controls.Add(instrHome);
            instrHome.BringToFront();

        }





        private void Instructor_Load(object sender, EventArgs e)
        {

        }




        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.HomeBtn.Top;
            InstrHome instrHome = new();
            this.Controls.Add(instrHome);
            instrHome.BringToFront();


        }

        private void AddQuesBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.AddQuesBtn.Top;
            AddQues addQuesCtrl = new();
            this.Controls.Add(addQuesCtrl);

            addQuesCtrl.BringToFront();

        }

        private void AddExamBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.AddExamBtn.Top;
            AddExam addExamCtrl = new();
            this.Controls.Add(addExamCtrl);

            addExamCtrl.BringToFront();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {


            Application.Exit();


        }

        private void MinimBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }



        private void AddCrsBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = AddCrsBtn.Top;
            AddCrsCtrl addCrsCtrl = new();
            this.Controls.Add(addCrsCtrl);

            addCrsCtrl.BringToFront();



        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = manageBtn.Top;
            Manage manageCtrl = new();
            this.Controls.Add(manageCtrl);

            manageCtrl.BringToFront();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rprtsBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.rprtsBtn.Top;
            reports rprtCtrl = new();
            this.Controls.Add(rprtCtrl);

            rprtCtrl.BringToFront();
        }

        private void Instructor_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Instructor_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Instructor_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void deptBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.deptBtn.Top;
            AddDeptCtrl dept = new();
            this.Controls.Add(dept);
            dept.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
