namespace Examination_System
{
    partial class InstrHome
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
            containerPanel = new Panel();
            InstructorHome = new PictureBox();
            containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InstructorHome).BeginInit();
            SuspendLayout();
            // 
            // containerPanel
            // 
            containerPanel.Controls.Add(InstructorHome);
            containerPanel.Location = new Point(0, 0);
            containerPanel.Margin = new Padding(0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1176, 680);
            containerPanel.TabIndex = 8;
            containerPanel.Paint += containerPanel_Paint;
            // 
            // InstructorHome
            // 
            InstructorHome.Location = new Point(223, 22);
            InstructorHome.Name = "InstructorHome";
            InstructorHome.Size = new Size(743, 625);
            InstructorHome.SizeMode = PictureBoxSizeMode.Zoom;
            InstructorHome.TabIndex = 0;
            InstructorHome.TabStop = false;
            // 
            // InstrHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(containerPanel);
            Location = new Point(277, 140);
            Margin = new Padding(0);
            Name = "InstrHome";
            Size = new Size(1176, 680);
            containerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InstructorHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel containerPanel;
        private PictureBox InstructorHome;
    }
}
