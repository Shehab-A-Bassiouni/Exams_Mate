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
    public partial class AddCrsCtrl : UserControl
    {
        success succ;
        public AddCrsCtrl()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            succ = new("Added");
            this.Controls.Add(succ);
            succ.BringToFront();
        }
    }
}
