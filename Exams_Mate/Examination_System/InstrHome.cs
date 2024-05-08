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
    public partial class InstrHome : UserControl
    {
        public InstrHome()
        {
            InitializeComponent();
            LoadInstrHomeImg("../../Images/InstructorHome.svg");

        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadInstrHomeImg(string path)
        {
            var svg = SvgDocument.Open(path);
            var bitmap = svg.Draw();
            this.InstructorHome.Image = bitmap;
        }
    }
}
