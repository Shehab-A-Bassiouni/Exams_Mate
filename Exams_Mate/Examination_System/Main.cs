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

namespace Examination_System
{
    public partial class Main : Form
    {
        Instructor instructor;
        Student student;
        bool mouseDown;
        Point lastLocation;
        ITI_Exam_SystemContext ctx;
        string username;
        string password;
        string type;
        success success_ctrl;
        public Main()
        {
            ctx = new();
            InitializeComponent();
            string msg = """
                Student Fast Login
                ######
                userName: student
                password: student
                ---------------------------
                Instructor Fast Login
                ######
                username: instructor
                password: instructor
                """;
            MessageBox.Show(msg, "Login Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private string Login() {
           username = this.userNameTxtBx.Text;
           password = this.PassTxtBx.Text;

            var parameters = new[]
            {
    new SqlParameter("@username", username),
    new SqlParameter("@password", password),
    new SqlParameter("@type", System.Data.SqlDbType.NVarChar, 20) { Direction = System.Data.ParameterDirection.Output }
};

            var output = ctx.Database.ExecuteSqlRaw("EXEC UserLogInVerification @username, @password, @type OUTPUT", parameters);

            type = Convert.ToString(parameters[2].Value);

            return type??"Invalid";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructor = new();
            instructor.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            student = new();
            student.ShowDialog();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            LoginManager.Login(this.userNameTxtBx.Text, this.PassTxtBx.Text);

            if (LoginManager.UserType == 1)
            {
                MessageBox.Show("Welcome Back!","Success Login",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.Hide();
                instructor = new();
                instructor.ShowDialog();
                CurrentUser.UserName = username;

			}

            else if (LoginManager.UserType == 2)
            {
                MessageBox.Show("Welcome Back!", "Success Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                student = new();
                student.ShowDialog();
                CurrentUser.UserName = username;

            }

            else {
                MessageBox.Show("Invalid Login Attemp", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
