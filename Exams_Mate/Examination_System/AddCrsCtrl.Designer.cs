namespace Examination_System
{
    partial class AddCrsCtrl
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCrsName = new TextBox();
            numericHours = new NumericUpDown();
            numericGrades = new NumericUpDown();
            ntActiveRad = new RadioButton();
            actvRad = new RadioButton();
            crsDescripTxtBx = new RichTextBox();
            AddBtn = new Button();
            label7 = new Label();
            deptComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGrades).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(96, 72);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 18;
            label1.Text = "Course name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(178, 8, 55);
            label3.Location = new Point(96, 225);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 19;
            label3.Text = "State:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(96, 306);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 20;
            label4.Text = "Hours:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(178, 8, 55);
            label5.Location = new Point(548, 308);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 21;
            label5.Text = "Total Grades:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(96, 394);
            label6.Name = "label6";
            label6.Size = new Size(149, 28);
            label6.TabIndex = 22;
            label6.Text = "Description:";
            // 
            // txtCrsName
            // 
            txtCrsName.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            txtCrsName.ForeColor = Color.FromArgb(41, 39, 40);
            txtCrsName.Location = new Point(405, 69);
            txtCrsName.Name = "txtCrsName";
            txtCrsName.Size = new Size(309, 37);
            txtCrsName.TabIndex = 25;
            // 
            // numericHours
            // 
            numericHours.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericHours.ForeColor = Color.FromArgb(41, 39, 40);
            numericHours.Location = new Point(290, 306);
            numericHours.Name = "numericHours";
            numericHours.Size = new Size(120, 37);
            numericHours.TabIndex = 26;
            // 
            // numericGrades
            // 
            numericGrades.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericGrades.ForeColor = Color.FromArgb(41, 39, 40);
            numericGrades.Location = new Point(780, 308);
            numericGrades.Name = "numericGrades";
            numericGrades.Size = new Size(120, 37);
            numericGrades.TabIndex = 27;
            // 
            // ntActiveRad
            // 
            ntActiveRad.AutoSize = true;
            ntActiveRad.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            ntActiveRad.ForeColor = Color.FromArgb(41, 39, 40);
            ntActiveRad.Location = new Point(562, 223);
            ntActiveRad.Name = "ntActiveRad";
            ntActiveRad.Size = new Size(151, 32);
            ntActiveRad.TabIndex = 33;
            ntActiveRad.TabStop = true;
            ntActiveRad.Text = "Not Active";
            ntActiveRad.UseVisualStyleBackColor = true;
            // 
            // actvRad
            // 
            actvRad.AutoSize = true;
            actvRad.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            actvRad.ForeColor = Color.FromArgb(41, 39, 40);
            actvRad.Location = new Point(412, 223);
            actvRad.Name = "actvRad";
            actvRad.Size = new Size(104, 32);
            actvRad.TabIndex = 32;
            actvRad.TabStop = true;
            actvRad.Text = "Active";
            actvRad.UseVisualStyleBackColor = true;
            // 
            // crsDescripTxtBx
            // 
            crsDescripTxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            crsDescripTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            crsDescripTxtBx.Location = new Point(405, 398);
            crsDescripTxtBx.Name = "crsDescripTxtBx";
            crsDescripTxtBx.Size = new Size(415, 94);
            crsDescripTxtBx.TabIndex = 34;
            crsDescripTxtBx.Text = "Enter Course Description..";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(58, 115, 193);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(412, 553);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(257, 59);
            AddBtn.TabIndex = 35;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(178, 8, 55);
            label7.Location = new Point(96, 151);
            label7.Name = "label7";
            label7.Size = new Size(157, 28);
            label7.TabIndex = 36;
            label7.Text = "Department:";
            // 
            // deptComboBox
            // 
            deptComboBox.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            deptComboBox.ForeColor = Color.FromArgb(41, 39, 40);
            deptComboBox.FormattingEnabled = true;
            deptComboBox.Location = new Point(405, 151);
            deptComboBox.Name = "deptComboBox";
            deptComboBox.Size = new Size(428, 36);
            deptComboBox.TabIndex = 37;
            // 
            // AddCrsCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(deptComboBox);
            Controls.Add(label7);
            Controls.Add(AddBtn);
            Controls.Add(crsDescripTxtBx);
            Controls.Add(ntActiveRad);
            Controls.Add(actvRad);
            Controls.Add(numericGrades);
            Controls.Add(numericHours);
            Controls.Add(txtCrsName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Location = new Point(277, 140);
            Margin = new Padding(0);
            Name = "AddCrsCtrl";
            Size = new Size(1176, 680);
            Load += AddCrsCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)numericHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCrsName;
        private NumericUpDown numericHours;
        private NumericUpDown numericGrades;
        private RadioButton ntActiveRad;
        private RadioButton actvRad;
        private RichTextBox crsDescripTxtBx;
        private Button AddBtn;
		private Label label7;
		private ComboBox deptComboBox;
	}
}
