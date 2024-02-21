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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(82, 72);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 0;
            label1.Text = "Exam Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(82, 153);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 1;
            label2.Text = "Instructor ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(178, 8, 55);
            label3.Location = new Point(82, 232);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 2;
            label3.Text = "Course ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(82, 304);
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
            label5.Location = new Point(82, 378);
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
            label6.Location = new Point(82, 445);
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
            label7.Location = new Point(82, 511);
            label7.Name = "label7";
            label7.Size = new Size(436, 28);
            label7.TabIndex = 6;
            label7.Text = "Number of True and False Questions:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(58, 115, 193);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(448, 583);
            button1.Name = "button1";
            button1.Size = new Size(257, 59);
            button1.TabIndex = 7;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(41, 39, 40);
            textBox1.Location = new Point(434, 72);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(309, 37);
            textBox1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericUpDown1.ForeColor = Color.FromArgb(41, 39, 40);
            numericUpDown1.Location = new Point(434, 376);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 37);
            numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericUpDown2.ForeColor = Color.FromArgb(41, 39, 40);
            numericUpDown2.Location = new Point(434, 443);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 37);
            numericUpDown2.TabIndex = 10;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericUpDown3.ForeColor = Color.FromArgb(41, 39, 40);
            numericUpDown3.Location = new Point(571, 509);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 37);
            numericUpDown3.TabIndex = 11;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            numericUpDown4.ForeColor = Color.FromArgb(41, 39, 40);
            numericUpDown4.Location = new Point(434, 302);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 37);
            numericUpDown4.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            comboBox1.ForeColor = Color.FromArgb(41, 39, 40);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(434, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 36);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            comboBox2.ForeColor = Color.FromArgb(41, 39, 40);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(434, 229);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(309, 36);
            comboBox2.TabIndex = 14;
            // 
            // AddExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(277, 140);
            Name = "AddExam";
            Size = new Size(1176, 680);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
