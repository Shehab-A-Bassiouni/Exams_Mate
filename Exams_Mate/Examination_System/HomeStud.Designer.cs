namespace Examination_System
{
    partial class HomeStud
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            StudentHome = new PictureBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentHome).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(StudentHome);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1170, 674);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint;
            // 
            // StudentHome
            // 
            StudentHome.Location = new Point(223, 22);
            StudentHome.Name = "StudentHome";
            StudentHome.Size = new Size(743, 625);
            StudentHome.SizeMode = PictureBoxSizeMode.Zoom;
            StudentHome.TabIndex = 0;
            StudentHome.TabStop = false;
            // 
            // HomeStud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel4);
            Location = new Point(277, 140);
            Margin = new Padding(0);
            Name = "HomeStud";
            Size = new Size(1176, 680);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private PictureBox StudentHome;
    }
}
