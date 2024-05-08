namespace Examination_System
{
    partial class GrdsStud
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtExamNo = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(337, 49);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 17;
            label2.Text = "Exam:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            comboBox1.ForeColor = Color.FromArgb(41, 39, 40);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(463, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 36);
            comboBox1.TabIndex = 19;
            comboBox1.Click += comboBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(33, 309);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 21;
            label4.Text = "Exam Grade:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(178, 8, 55);
            label10.Location = new Point(33, 398);
            label10.Name = "label10";
            label10.Size = new Size(70, 28);
            label10.TabIndex = 28;
            label10.Text = "Pass:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(178, 8, 55);
            label11.Location = new Point(33, 248);
            label11.Name = "label11";
            label11.Size = new Size(101, 28);
            label11.TabIndex = 29;
            label11.Text = "Course:";
            // 
            // txtExamNo
            // 
            txtExamNo.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            txtExamNo.ForeColor = Color.FromArgb(41, 39, 40);
            txtExamNo.Location = new Point(247, 245);
            txtExamNo.Margin = new Padding(3, 2, 3, 2);
            txtExamNo.Name = "txtExamNo";
            txtExamNo.ReadOnly = true;
            txtExamNo.Size = new Size(309, 37);
            txtExamNo.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(41, 39, 40);
            textBox1.Location = new Point(247, 310);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(309, 37);
            textBox1.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            textBox3.ForeColor = Color.FromArgb(41, 39, 40);
            textBox3.Location = new Point(247, 395);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(309, 37);
            textBox3.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(33, 482);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 38;
            label1.Text = "Instructor:";
            // 
            // GrdsStud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(txtExamNo);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Location = new Point(277, 140);
            Name = "GrdsStud";
            Size = new Size(1176, 680);
            Load += GrdsStud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label10;
        private Label label11;
        private TextBox txtExamNo;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
    }
}
