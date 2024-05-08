namespace Examination_System
{
    partial class manageCourseInstr
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
            label1 = new Label();
            comboBoxCrs = new ComboBox();
            crsDescripTxtBx = new RichTextBox();
            ntActiveRad = new RadioButton();
            actvRad = new RadioButton();
            numericGrades = new NumericUpDown();
            numericHours = new NumericUpDown();
            txtCrsName = new TextBox();
            CrsIdTxtBx = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            Editbtn = new Button();
            delBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericGrades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHours).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(342, 29);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 50;
            label1.Text = "Course:";
            // 
            // comboBoxCrs
            // 
            comboBoxCrs.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            comboBoxCrs.ForeColor = Color.FromArgb(41, 39, 40);
            comboBoxCrs.FormattingEnabled = true;
            comboBoxCrs.Location = new Point(472, 26);
            comboBoxCrs.Name = "comboBoxCrs";
            comboBoxCrs.Size = new Size(309, 36);
            comboBoxCrs.TabIndex = 51;
            comboBoxCrs.SelectedIndexChanged += comboBoxCrs_SelectedIndexChanged;
            comboBoxCrs.Click += comboBoxCrs_Click;
            // 
            // crsDescripTxtBx
            // 
            crsDescripTxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            crsDescripTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            crsDescripTxtBx.Location = new Point(342, 440);
            crsDescripTxtBx.Name = "crsDescripTxtBx";
            crsDescripTxtBx.Size = new Size(415, 94);
            crsDescripTxtBx.TabIndex = 64;
            crsDescripTxtBx.Text = "Edit Course Description..";
            // 
            // ntActiveRad
            // 
            ntActiveRad.AutoSize = true;
            ntActiveRad.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            ntActiveRad.ForeColor = Color.FromArgb(41, 39, 40);
            ntActiveRad.Location = new Point(499, 265);
            ntActiveRad.Name = "ntActiveRad";
            ntActiveRad.Size = new Size(151, 32);
            ntActiveRad.TabIndex = 63;
            ntActiveRad.TabStop = true;
            ntActiveRad.Text = "Not Active";
            ntActiveRad.UseVisualStyleBackColor = true;
            // 
            // actvRad
            // 
            actvRad.AutoSize = true;
            actvRad.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            actvRad.ForeColor = Color.FromArgb(41, 39, 40);
            actvRad.Location = new Point(349, 265);
            actvRad.Name = "actvRad";
            actvRad.Size = new Size(104, 32);
            actvRad.TabIndex = 62;
            actvRad.TabStop = true;
            actvRad.Text = "Active";
            actvRad.UseVisualStyleBackColor = true;
            // 
            // numericGrades
            // 
            numericGrades.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericGrades.ForeColor = Color.FromArgb(41, 39, 40);
            numericGrades.Location = new Point(717, 350);
            numericGrades.Name = "numericGrades";
            numericGrades.Size = new Size(120, 37);
            numericGrades.TabIndex = 61;
            // 
            // numericHours
            // 
            numericHours.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericHours.ForeColor = Color.FromArgb(41, 39, 40);
            numericHours.Location = new Point(227, 348);
            numericHours.Name = "numericHours";
            numericHours.Size = new Size(120, 37);
            numericHours.TabIndex = 60;
            // 
            // txtCrsName
            // 
            txtCrsName.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            txtCrsName.ForeColor = Color.FromArgb(41, 39, 40);
            txtCrsName.Location = new Point(342, 191);
            txtCrsName.Name = "txtCrsName";
            txtCrsName.Size = new Size(309, 37);
            txtCrsName.TabIndex = 59;
            // 
            // CrsIdTxtBx
            // 
            CrsIdTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            CrsIdTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            CrsIdTxtBx.Location = new Point(342, 123);
            CrsIdTxtBx.Name = "CrsIdTxtBx";
            CrsIdTxtBx.ReadOnly = true;
            CrsIdTxtBx.Size = new Size(309, 37);
            CrsIdTxtBx.TabIndex = 58;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(33, 436);
            label6.Name = "label6";
            label6.Size = new Size(149, 28);
            label6.TabIndex = 57;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(178, 8, 55);
            label5.Location = new Point(485, 350);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 56;
            label5.Text = "Total Grades:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(33, 348);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 55;
            label4.Text = "Hours:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(178, 8, 55);
            label3.Location = new Point(33, 267);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 54;
            label3.Text = "State:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(33, 194);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 53;
            label2.Text = "Course name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(178, 8, 55);
            label8.Location = new Point(33, 123);
            label8.Name = "label8";
            label8.Size = new Size(132, 28);
            label8.TabIndex = 52;
            label8.Text = "Course ID:";
            // 
            // Editbtn
            // 
            Editbtn.BackColor = Color.FromArgb(58, 115, 193);
            Editbtn.FlatStyle = FlatStyle.Flat;
            Editbtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Editbtn.ForeColor = Color.White;
            Editbtn.Location = new Point(124, 585);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(257, 59);
            Editbtn.TabIndex = 67;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.Maroon;
            delBtn.FlatStyle = FlatStyle.Flat;
            delBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delBtn.ForeColor = Color.White;
            delBtn.Location = new Point(580, 585);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(257, 59);
            delBtn.TabIndex = 68;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // manageCourseInstr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(delBtn);
            Controls.Add(Editbtn);
            Controls.Add(crsDescripTxtBx);
            Controls.Add(ntActiveRad);
            Controls.Add(actvRad);
            Controls.Add(numericGrades);
            Controls.Add(numericHours);
            Controls.Add(txtCrsName);
            Controls.Add(CrsIdTxtBx);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(comboBoxCrs);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "manageCourseInstr";
            Size = new Size(1176, 680);
            Load += manageCourseInstr_Load;
            ((System.ComponentModel.ISupportInitialize)numericGrades).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCrs;
        private RichTextBox crsDescripTxtBx;
        private RadioButton ntActiveRad;
        private RadioButton actvRad;
        private NumericUpDown numericGrades;
        private NumericUpDown numericHours;
        private TextBox txtCrsName;
        private TextBox CrsIdTxtBx;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Button Editbtn;
        private Button delBtn;
    }
}
