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
        AddExam addExamCtrl;
        AddQues addQuesCtrl;
        AddCrsCtrl addCrsCtrl;
        Manage manageCtrl;
        public Instructor()
        {
            InitializeComponent();
            addControls();
            LoadInstrHomeImg("../../Images/InstructorHome.svg");
            this.cpyright.Text = "Copyright \u00A9 DB Team 4\r\n";

        }





        private void Instructor_Load(object sender, EventArgs e)
        {

        }

        private void LoadInstrHomeImg(string path)
        {
            var svg = SvgDocument.Open(path);
            var bitmap = svg.Draw();
            this.InstructorHome.Image = bitmap;
        }





        private void addControls()
        {
            addExamCtrl = new();
            this.Controls.Add(addExamCtrl);

            addQuesCtrl = new();
            this.Controls.Add(addQuesCtrl);

            addCrsCtrl = new();
            this.Controls.Add(addCrsCtrl);

            manageCtrl = new();
            this.Controls.Add(manageCtrl);


        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.HomeBtn.Top;
            ShowHome();



        }

        private void AddQuesBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.AddQuesBtn.Top;
            addQuesCtrl.BringToFront();

        }

        private void AddExamBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.AddExamBtn.Top;
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

        private void ShowHome()
        {
            addExamCtrl.SendToBack();
            addQuesCtrl.SendToBack();
            addCrsCtrl.SendToBack();
            manageCtrl.SendToBack();
        }

        private void AddCrsBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = AddCrsBtn.Top;
            addCrsCtrl.BringToFront();
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = manageBtn.Top;
            manageCtrl.BringToFront();

        }
    }
}
