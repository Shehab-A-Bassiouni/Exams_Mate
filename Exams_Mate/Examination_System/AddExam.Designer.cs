namespace Examination_System
{
    partial class AddExam
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            generateBtn = new Button();
            numericGrade = new NumericUpDown();
            numericMCQ = new NumericUpDown();
            numericTF = new NumericUpDown();
            numericMinutes = new NumericUpDown();
            comboBoxCrsID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMCQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMinutes).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(178, 8, 55);
            label3.Location = new Point(75, 107);
            label3.Name = "label3";
            label3.Size = new Size(180, 28);
            label3.TabIndex = 2;
            label3.Text = "Course Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(75, 179);
            label4.Name = "label4";
            label4.Size = new Size(239, 28);
            label4.TabIndex = 3;
            label4.Text = "Duration in Minutes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(178, 8, 55);
            label5.Location = new Point(75, 253);
            label5.Name = "label5";
            label5.Size = new Size(188, 28);
            label5.TabIndex = 4;
            label5.Text = "Passing Grade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(75, 320);
            label6.Name = "label6";
            label6.Size = new Size(330, 28);
            label6.TabIndex = 5;
            label6.Text = "Number of MCQ Questions:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(178, 8, 55);
            label7.Location = new Point(75, 386);
            label7.Name = "label7";
            label7.Size = new Size(436, 28);
            label7.TabIndex = 6;
            label7.Text = "Number of True and False Questions:";
            // 
            // generateBtn
            // 
            generateBtn.BackColor = Color.FromArgb(58, 115, 193);
            generateBtn.FlatStyle = FlatStyle.Flat;
            generateBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generateBtn.ForeColor = Color.White;
            generateBtn.Location = new Point(449, 527);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(257, 59);
            generateBtn.TabIndex = 7;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = false;
            generateBtn.Click += generateBtn_Click;
            // 
            // numericGrade
            // 
            numericGrade.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericGrade.ForeColor = Color.FromArgb(41, 39, 40);
            numericGrade.Location = new Point(427, 251);
            numericGrade.Name = "numericGrade";
            numericGrade.Size = new Size(120, 37);
            numericGrade.TabIndex = 9;
            // 
            // numericMCQ
            // 
            numericMCQ.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericMCQ.ForeColor = Color.FromArgb(41, 39, 40);
            numericMCQ.Location = new Point(427, 318);
            numericMCQ.Name = "numericMCQ";
            numericMCQ.Size = new Size(120, 37);
            numericMCQ.TabIndex = 10;
            // 
            // numericTF
            // 
            numericTF.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericTF.ForeColor = Color.FromArgb(41, 39, 40);
            numericTF.Location = new Point(564, 384);
            numericTF.Name = "numericTF";
            numericTF.Size = new Size(120, 37);
            numericTF.TabIndex = 11;
            // 
            // numericMinutes
            // 
            numericMinutes.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericMinutes.ForeColor = Color.FromArgb(41, 39, 40);
            numericMinutes.Location = new Point(427, 177);
            numericMinutes.Name = "numericMinutes";
            numericMinutes.Size = new Size(120, 37);
            numericMinutes.TabIndex = 12;
            // 
            // comboBoxCrsID
            // 
            comboBoxCrsID.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            comboBoxCrsID.ForeColor = Color.FromArgb(41, 39, 40);
            comboBoxCrsID.FormattingEnabled = true;
            comboBoxCrsID.Location = new Point(427, 104);
            comboBoxCrsID.Name = "comboBoxCrsID";
            comboBoxCrsID.Size = new Size(428, 36);
            comboBoxCrsID.TabIndex = 14;
            comboBoxCrsID.Click += comboBoxCrsID_Click;
            // 
            // AddExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBoxCrsID);
            Controls.Add(numericMinutes);
            Controls.Add(numericTF);
            Controls.Add(numericMCQ);
            Controls.Add(numericGrade);
            Controls.Add(generateBtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Location = new Point(277, 140);
            Margin = new Padding(0);
            Name = "AddExam";
            Size = new Size(1176, 680);
            Load += AddExam_Load;
            ((System.ComponentModel.ISupportInitialize)numericGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMCQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTF).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button generateBtn;
        private NumericUpDown numericGrade;
        private NumericUpDown numericMCQ;
        private NumericUpDown numericTF;
        private NumericUpDown numericMinutes;
        private ComboBox comboBoxCrsID;
    }
}
