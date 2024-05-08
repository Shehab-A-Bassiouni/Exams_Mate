namespace Examination_System
{
    partial class joinStud
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
            comboBoxCrs = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            joinBtn = new Button();
            crsNameTxtBx = new TextBox();
            CrsTotalGradeTxtBx = new TextBox();
            crsDescripTxtbx = new RichTextBox();
            label8 = new Label();
            CrsHoursTxtBx = new TextBox();
            CrsInstrTxtBx = new RichTextBox();
            SuspendLayout();
            // 
            // comboBoxCrs
            // 
            comboBoxCrs.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            comboBoxCrs.ForeColor = Color.FromArgb(41, 39, 40);
            comboBoxCrs.FormattingEnabled = true;
            comboBoxCrs.Location = new Point(470, 17);
            comboBoxCrs.Name = "comboBoxCrs";
            comboBoxCrs.Size = new Size(309, 36);
            comboBoxCrs.TabIndex = 20;
            comboBoxCrs.SelectedIndexChanged += comboBoxCrs_SelectedIndexChanged;
            comboBoxCrs.Click += comboBoxCrs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(340, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 19;
            label1.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(178, 8, 55);
            label3.Location = new Point(19, 98);
            label3.Name = "label3";
            label3.Size = new Size(180, 28);
            label3.TabIndex = 21;
            label3.Text = "Course Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(19, 162);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 22;
            label2.Text = "Course Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(19, 258);
            label4.Name = "label4";
            label4.Size = new Size(255, 28);
            label4.TabIndex = 23;
            label4.Text = "Course Total Grades:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(19, 395);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 25;
            label6.Text = "Instructors:";
            // 
            // joinBtn
            // 
            joinBtn.BackColor = Color.FromArgb(58, 115, 193);
            joinBtn.FlatStyle = FlatStyle.Flat;
            joinBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            joinBtn.ForeColor = Color.White;
            joinBtn.Location = new Point(451, 530);
            joinBtn.Name = "joinBtn";
            joinBtn.Size = new Size(257, 59);
            joinBtn.TabIndex = 28;
            joinBtn.Text = "Join";
            joinBtn.UseVisualStyleBackColor = false;
            joinBtn.Click += joinBtn_Click;
            // 
            // crsNameTxtBx
            // 
            crsNameTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            crsNameTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            crsNameTxtBx.Location = new Point(356, 95);
            crsNameTxtBx.Margin = new Padding(3, 2, 3, 2);
            crsNameTxtBx.Name = "crsNameTxtBx";
            crsNameTxtBx.ReadOnly = true;
            crsNameTxtBx.Size = new Size(423, 37);
            crsNameTxtBx.TabIndex = 35;
            // 
            // CrsTotalGradeTxtBx
            // 
            CrsTotalGradeTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            CrsTotalGradeTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            CrsTotalGradeTxtBx.Location = new Point(356, 255);
            CrsTotalGradeTxtBx.Margin = new Padding(3, 2, 3, 2);
            CrsTotalGradeTxtBx.Name = "CrsTotalGradeTxtBx";
            CrsTotalGradeTxtBx.ReadOnly = true;
            CrsTotalGradeTxtBx.Size = new Size(423, 37);
            CrsTotalGradeTxtBx.TabIndex = 36;
            // 
            // crsDescripTxtbx
            // 
            crsDescripTxtbx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            crsDescripTxtbx.ForeColor = Color.FromArgb(41, 39, 40);
            crsDescripTxtbx.Location = new Point(356, 162);
            crsDescripTxtbx.Name = "crsDescripTxtbx";
            crsDescripTxtbx.ReadOnly = true;
            crsDescripTxtbx.Size = new Size(423, 71);
            crsDescripTxtbx.TabIndex = 46;
            crsDescripTxtbx.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(178, 8, 55);
            label8.Location = new Point(19, 331);
            label8.Name = "label8";
            label8.Size = new Size(170, 28);
            label8.TabIndex = 47;
            label8.Text = "Course hours:";
            // 
            // CrsHoursTxtBx
            // 
            CrsHoursTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            CrsHoursTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            CrsHoursTxtBx.Location = new Point(356, 328);
            CrsHoursTxtBx.Margin = new Padding(3, 2, 3, 2);
            CrsHoursTxtBx.Name = "CrsHoursTxtBx";
            CrsHoursTxtBx.ReadOnly = true;
            CrsHoursTxtBx.Size = new Size(423, 37);
            CrsHoursTxtBx.TabIndex = 48;
            // 
            // CrsInstrTxtBx
            // 
            CrsInstrTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            CrsInstrTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            CrsInstrTxtBx.Location = new Point(356, 386);
            CrsInstrTxtBx.Name = "CrsInstrTxtBx";
            CrsInstrTxtBx.ReadOnly = true;
            CrsInstrTxtBx.Size = new Size(423, 65);
            CrsInstrTxtBx.TabIndex = 49;
            CrsInstrTxtBx.Text = "";
            // 
            // joinStud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CrsInstrTxtBx);
            Controls.Add(CrsHoursTxtBx);
            Controls.Add(label8);
            Controls.Add(crsDescripTxtbx);
            Controls.Add(CrsTotalGradeTxtBx);
            Controls.Add(crsNameTxtBx);
            Controls.Add(joinBtn);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboBoxCrs);
            Controls.Add(label1);
            Location = new Point(277, 140);
            Margin = new Padding(0);
            Name = "joinStud";
            Size = new Size(1176, 680);
            Load += joinStud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCrs;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private Button joinBtn;
        private TextBox crsNameTxtBx;
        private TextBox CrsTotalGradeTxtBx;
        private RichTextBox crsDescripTxtbx;
        private Label label8;
        private TextBox CrsHoursTxtBx;
        private RichTextBox CrsInstrTxtBx;
    }
}
