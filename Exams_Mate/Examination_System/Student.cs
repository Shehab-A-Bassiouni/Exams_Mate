
namespace Examination_System
{
    public partial class Student : Form
    {
      
       bool mouseDown;
        Point lastLocation;
        public Student()
        {
            InitializeComponent();
            this.cpyright.Text = "Copyright \u00A9 DB Team 4\r\n";
            HomeStud home = new();
            this.Controls.Add(home);
            home.BringToFront();

        }

   

      
       

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MinimBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.homeBtn.Top;
            HomeStud home = new();
            this.Controls.Add(home);
            home.BringToFront();
        }


      

       

        private void slvBtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.slvBtn.Top;
            slvStud slv = new();
            this.Controls.Add(slv);

            slv.BringToFront();
        }

        private void joinbtn_Click(object sender, EventArgs e)
        {
            this.SidePanel.Top = this.joinbtn.Top;
            joinStud jin = new();
            this.Controls.Add(jin);

            jin.BringToFront();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void Student_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Student_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Student_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
