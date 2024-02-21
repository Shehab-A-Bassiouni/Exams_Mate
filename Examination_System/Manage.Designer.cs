namespace Examination_System
{
    partial class Manage
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
            AddBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(58, 115, 193);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(165, 382);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(257, 59);
            AddBtn.TabIndex = 23;
            AddBtn.Text = "Manage Exams";
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(58, 115, 193);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(165, 206);
            button1.Name = "button1";
            button1.Size = new Size(306, 59);
            button1.TabIndex = 24;
            button1.Text = "Manage Courses";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(58, 115, 193);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(165, 295);
            button2.Name = "button2";
            button2.Size = new Size(306, 59);
            button2.TabIndex = 25;
            button2.Text = "Manage Questions";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(58, 115, 193);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(579, 206);
            button3.Name = "button3";
            button3.Size = new Size(365, 59);
            button3.TabIndex = 26;
            button3.Text = "Manage Departments";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(58, 115, 193);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(579, 295);
            button4.Name = "button4";
            button4.Size = new Size(365, 59);
            button4.TabIndex = 27;
            button4.Text = "Manage Instructors";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(58, 115, 193);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(579, 382);
            button5.Name = "button5";
            button5.Size = new Size(365, 59);
            button5.TabIndex = 28;
            button5.Text = "Manage Students";
            button5.UseVisualStyleBackColor = false;
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AddBtn);
            Location = new Point(277, 140);
            Name = "Manage";
            Size = new Size(1176, 680);
            ResumeLayout(false);
        }

        #endregion

        private Button AddBtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
