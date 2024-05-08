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
    public partial class HomeStud : UserControl
    {
        public HomeStud()
        {
            InitializeComponent();
            LoadStudHomeImg("../../Images/StudentHome.svg");

        }

        private void LoadStudHomeImg(string path)
        {
            var svg = SvgDocument.Open(path);
            var bitmap = svg.Draw();
            this.StudentHome.Image = bitmap;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
