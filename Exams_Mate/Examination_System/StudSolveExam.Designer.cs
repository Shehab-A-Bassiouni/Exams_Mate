namespace Examination_System
{
    partial class StudSolveExam
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
            Qlbl = new Label();
            OptionsPanel = new Panel();
            label5 = new Label();
            Opt4TxtBx = new RichTextBox();
            Opt3TxtBx = new RichTextBox();
            Opt1TxtBx = new RichTextBox();
            Opt2TxtBx = new RichTextBox();
            CrctAnsCombo = new ComboBox();
            label6 = new Label();
            QContentTxtBx = new RichTextBox();
            label4 = new Label();
            sbmtBtn = new Button();
            subQues = new Button();
            prevBtn = new Button();
            OptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Qlbl
            // 
            Qlbl.AutoSize = true;
            Qlbl.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Qlbl.ForeColor = Color.FromArgb(178, 8, 55);
            Qlbl.Location = new Point(463, 10);
            Qlbl.Name = "Qlbl";
            Qlbl.Size = new Size(125, 28);
            Qlbl.TabIndex = 42;
            Qlbl.Text = "Questions";
            Qlbl.Click += label1_Click;
            // 
            // OptionsPanel
            // 
            OptionsPanel.Controls.Add(label5);
            OptionsPanel.Controls.Add(Opt4TxtBx);
            OptionsPanel.Controls.Add(Opt3TxtBx);
            OptionsPanel.Controls.Add(Opt1TxtBx);
            OptionsPanel.Controls.Add(Opt2TxtBx);
            OptionsPanel.Location = new Point(19, 343);
            OptionsPanel.Name = "OptionsPanel";
            OptionsPanel.Size = new Size(1136, 170);
            OptionsPanel.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(178, 8, 55);
            label5.Location = new Point(42, 54);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 34;
            label5.Text = "Options:";
            // 
            // Opt4TxtBx
            // 
            Opt4TxtBx.Cursor = Cursors.IBeam;
            Opt4TxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Opt4TxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            Opt4TxtBx.Location = new Point(827, 16);
            Opt4TxtBx.Name = "Opt4TxtBx";
            Opt4TxtBx.ReadOnly = true;
            Opt4TxtBx.Size = new Size(182, 132);
            Opt4TxtBx.TabIndex = 38;
            Opt4TxtBx.Text = "Option 4 ..";
            // 
            // Opt3TxtBx
            // 
            Opt3TxtBx.Cursor = Cursors.IBeam;
            Opt3TxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Opt3TxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            Opt3TxtBx.Location = new Point(621, 16);
            Opt3TxtBx.Name = "Opt3TxtBx";
            Opt3TxtBx.ReadOnly = true;
            Opt3TxtBx.Size = new Size(176, 132);
            Opt3TxtBx.TabIndex = 37;
            Opt3TxtBx.Text = "Option 3 ..";
            // 
            // Opt1TxtBx
            // 
            Opt1TxtBx.Cursor = Cursors.IBeam;
            Opt1TxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Opt1TxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            Opt1TxtBx.Location = new Point(210, 16);
            Opt1TxtBx.Name = "Opt1TxtBx";
            Opt1TxtBx.ReadOnly = true;
            Opt1TxtBx.Size = new Size(172, 132);
            Opt1TxtBx.TabIndex = 35;
            Opt1TxtBx.Text = "Option 1 ..";
            // 
            // Opt2TxtBx
            // 
            Opt2TxtBx.Cursor = Cursors.IBeam;
            Opt2TxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Opt2TxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            Opt2TxtBx.Location = new Point(416, 16);
            Opt2TxtBx.Name = "Opt2TxtBx";
            Opt2TxtBx.ReadOnly = true;
            Opt2TxtBx.Size = new Size(180, 132);
            Opt2TxtBx.TabIndex = 36;
            Opt2TxtBx.Text = "Option 2 ..";
            // 
            // CrctAnsCombo
            // 
            CrctAnsCombo.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            CrctAnsCombo.ForeColor = Color.FromArgb(41, 39, 40);
            CrctAnsCombo.FormattingEnabled = true;
            CrctAnsCombo.Location = new Point(419, 185);
            CrctAnsCombo.Name = "CrctAnsCombo";
            CrctAnsCombo.Size = new Size(263, 36);
            CrctAnsCombo.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(178, 185);
            label6.Name = "label6";
            label6.Size = new Size(198, 28);
            label6.TabIndex = 46;
            label6.Text = "Correct Answer:";
            // 
            // QContentTxtBx
            // 
            QContentTxtBx.Cursor = Cursors.IBeam;
            QContentTxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            QContentTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            QContentTxtBx.Location = new Point(322, 58);
            QContentTxtBx.Name = "QContentTxtBx";
            QContentTxtBx.ReadOnly = true;
            QContentTxtBx.Size = new Size(415, 94);
            QContentTxtBx.TabIndex = 45;
            QContentTxtBx.Text = "Enter Question Content..";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(178, 58);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 44;
            label4.Text = "Content:";
            // 
            // sbmtBtn
            // 
            sbmtBtn.BackColor = Color.FromArgb(58, 115, 193);
            sbmtBtn.FlatStyle = FlatStyle.Flat;
            sbmtBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbmtBtn.ForeColor = Color.White;
            sbmtBtn.Location = new Point(71, 605);
            sbmtBtn.Name = "sbmtBtn";
            sbmtBtn.Size = new Size(257, 59);
            sbmtBtn.TabIndex = 49;
            sbmtBtn.Text = "Next";
            sbmtBtn.UseVisualStyleBackColor = false;
            sbmtBtn.Click += sbmtBtn_Click;
            // 
            // subQues
            // 
            subQues.BackColor = Color.FromArgb(0, 64, 0);
            subQues.FlatStyle = FlatStyle.Flat;
            subQues.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subQues.ForeColor = Color.White;
            subQues.Location = new Point(419, 605);
            subQues.Name = "subQues";
            subQues.Size = new Size(335, 59);
            subQues.TabIndex = 50;
            subQues.Text = "Answer Question";
            subQues.UseVisualStyleBackColor = false;
            subQues.Click += subQues_Click;
            // 
            // prevBtn
            // 
            prevBtn.BackColor = Color.FromArgb(58, 115, 193);
            prevBtn.FlatStyle = FlatStyle.Flat;
            prevBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prevBtn.ForeColor = Color.White;
            prevBtn.Location = new Point(861, 605);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(257, 59);
            prevBtn.TabIndex = 51;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // StudSolveExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(prevBtn);
            Controls.Add(subQues);
            Controls.Add(sbmtBtn);
            Controls.Add(OptionsPanel);
            Controls.Add(CrctAnsCombo);
            Controls.Add(label6);
            Controls.Add(QContentTxtBx);
            Controls.Add(label4);
            Controls.Add(Qlbl);
            Margin = new Padding(0);
            Name = "StudSolveExam";
            Size = new Size(1176, 680);
            Load += StudSolveExam_Load;
            OptionsPanel.ResumeLayout(false);
            OptionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Qlbl;
        private Panel OptionsPanel;
        private Label label5;
        private RichTextBox Opt4TxtBx;
        private RichTextBox Opt3TxtBx;
        private RichTextBox Opt1TxtBx;
        private RichTextBox Opt2TxtBx;
        private ComboBox CrctAnsCombo;
        private Label label6;
        private RichTextBox QContentTxtBx;
        private Label label4;
        private Button sbmtBtn;
        private Button subQues;
        private Button prevBtn;
    }
}
