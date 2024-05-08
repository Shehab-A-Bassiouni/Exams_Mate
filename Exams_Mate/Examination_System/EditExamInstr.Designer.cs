namespace Examination_System
{
    partial class EditExamInstr
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
            comboBoxExmNum = new ComboBox();
            label1 = new Label();
            numericMinutes = new NumericUpDown();
            numericGrade = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            ntActiveRad = new RadioButton();
            actvRad = new RadioButton();
            Editbtn = new Button();
            delBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGrade).BeginInit();
            SuspendLayout();
            // 
            // comboBoxExmNum
            // 
            comboBoxExmNum.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            comboBoxExmNum.ForeColor = Color.FromArgb(41, 39, 40);
            comboBoxExmNum.FormattingEnabled = true;
            comboBoxExmNum.Location = new Point(549, 27);
            comboBoxExmNum.Name = "comboBoxExmNum";
            comboBoxExmNum.Size = new Size(309, 36);
            comboBoxExmNum.TabIndex = 53;
            comboBoxExmNum.SelectedIndexChanged += comboBoxExmNum_SelectedIndexChanged;
            comboBoxExmNum.Click += comboBoxExmNum_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(342, 30);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 52;
            label1.Text = "Exam Number:";
            // 
            // numericMinutes
            // 
            numericMinutes.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericMinutes.ForeColor = Color.FromArgb(41, 39, 40);
            numericMinutes.Location = new Point(398, 170);
            numericMinutes.Name = "numericMinutes";
            numericMinutes.Size = new Size(120, 37);
            numericMinutes.TabIndex = 57;
            // 
            // numericGrade
            // 
            numericGrade.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericGrade.ForeColor = Color.FromArgb(41, 39, 40);
            numericGrade.Location = new Point(398, 263);
            numericGrade.Name = "numericGrade";
            numericGrade.Size = new Size(120, 37);
            numericGrade.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(178, 8, 55);
            label5.Location = new Point(46, 265);
            label5.Name = "label5";
            label5.Size = new Size(188, 28);
            label5.TabIndex = 55;
            label5.Text = "Passing Grade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(46, 172);
            label4.Name = "label4";
            label4.Size = new Size(239, 28);
            label4.TabIndex = 54;
            label4.Text = "Duration in Minutes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(46, 357);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 58;
            label2.Text = "State:";
            // 
            // ntActiveRad
            // 
            ntActiveRad.AutoSize = true;
            ntActiveRad.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            ntActiveRad.ForeColor = Color.FromArgb(41, 39, 40);
            ntActiveRad.Location = new Point(405, 357);
            ntActiveRad.Name = "ntActiveRad";
            ntActiveRad.Size = new Size(103, 32);
            ntActiveRad.TabIndex = 66;
            ntActiveRad.TabStop = true;
            ntActiveRad.Text = "Ended";
            ntActiveRad.UseVisualStyleBackColor = true;
            // 
            // actvRad
            // 
            actvRad.AutoSize = true;
            actvRad.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            actvRad.ForeColor = Color.FromArgb(41, 39, 40);
            actvRad.Location = new Point(255, 357);
            actvRad.Name = "actvRad";
            actvRad.Size = new Size(104, 32);
            actvRad.TabIndex = 65;
            actvRad.TabStop = true;
            actvRad.Text = "Active";
            actvRad.UseVisualStyleBackColor = true;
            // 
            // Editbtn
            // 
            Editbtn.BackColor = Color.FromArgb(58, 115, 193);
            Editbtn.FlatStyle = FlatStyle.Flat;
            Editbtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Editbtn.ForeColor = Color.White;
            Editbtn.Location = new Point(219, 483);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(257, 59);
            Editbtn.TabIndex = 68;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.DarkRed;
            delBtn.FlatStyle = FlatStyle.Flat;
            delBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delBtn.ForeColor = Color.White;
            delBtn.Location = new Point(649, 483);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(257, 59);
            delBtn.TabIndex = 69;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // EditExamInstr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(delBtn);
            Controls.Add(Editbtn);
            Controls.Add(ntActiveRad);
            Controls.Add(actvRad);
            Controls.Add(label2);
            Controls.Add(numericMinutes);
            Controls.Add(numericGrade);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxExmNum);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "EditExamInstr";
            Size = new Size(1176, 680);
            Load += EditExamInstr_Load;
            ((System.ComponentModel.ISupportInitialize)numericMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxExmNum;
        private Label label1;
        private NumericUpDown numericMinutes;
        private NumericUpDown numericGrade;
        private Label label5;
        private Label label4;
        private Label label2;
        private RadioButton ntActiveRad;
        private RadioButton actvRad;
        private Button Editbtn;
        private Button delBtn;
    }
}
