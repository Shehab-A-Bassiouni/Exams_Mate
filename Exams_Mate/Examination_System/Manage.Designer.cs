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
            mngExamBtn = new Button();
            mngCrsBtn = new Button();
            mngQues = new Button();
            mngDeptbtn = new Button();
            SuspendLayout();
            // 
            // mngExamBtn
            // 
            mngExamBtn.BackColor = Color.FromArgb(58, 115, 193);
            mngExamBtn.Cursor = Cursors.Hand;
            mngExamBtn.FlatStyle = FlatStyle.Flat;
            mngExamBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mngExamBtn.ForeColor = Color.White;
            mngExamBtn.Location = new Point(579, 295);
            mngExamBtn.Name = "mngExamBtn";
            mngExamBtn.Size = new Size(257, 59);
            mngExamBtn.TabIndex = 23;
            mngExamBtn.Text = "Manage Exams";
            mngExamBtn.UseVisualStyleBackColor = false;
            mngExamBtn.Click += mngExamBtn_Click;
            // 
            // mngCrsBtn
            // 
            mngCrsBtn.BackColor = Color.FromArgb(58, 115, 193);
            mngCrsBtn.Cursor = Cursors.Hand;
            mngCrsBtn.FlatStyle = FlatStyle.Flat;
            mngCrsBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mngCrsBtn.ForeColor = Color.White;
            mngCrsBtn.Location = new Point(165, 206);
            mngCrsBtn.Name = "mngCrsBtn";
            mngCrsBtn.Size = new Size(306, 59);
            mngCrsBtn.TabIndex = 24;
            mngCrsBtn.Text = "Manage Courses";
            mngCrsBtn.UseVisualStyleBackColor = false;
            mngCrsBtn.Click += mngCrsBtn_Click;
            // 
            // mngQues
            // 
            mngQues.BackColor = Color.FromArgb(58, 115, 193);
            mngQues.Cursor = Cursors.Hand;
            mngQues.FlatStyle = FlatStyle.Flat;
            mngQues.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mngQues.ForeColor = Color.White;
            mngQues.Location = new Point(165, 295);
            mngQues.Name = "mngQues";
            mngQues.Size = new Size(306, 59);
            mngQues.TabIndex = 25;
            mngQues.Text = "Manage Questions";
            mngQues.UseVisualStyleBackColor = false;
            mngQues.Click += mngQues_Click;
            // 
            // mngDeptbtn
            // 
            mngDeptbtn.BackColor = Color.FromArgb(58, 115, 193);
            mngDeptbtn.Cursor = Cursors.Hand;
            mngDeptbtn.FlatStyle = FlatStyle.Flat;
            mngDeptbtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mngDeptbtn.ForeColor = Color.White;
            mngDeptbtn.Location = new Point(579, 206);
            mngDeptbtn.Name = "mngDeptbtn";
            mngDeptbtn.Size = new Size(365, 59);
            mngDeptbtn.TabIndex = 26;
            mngDeptbtn.Text = "Manage Departments";
            mngDeptbtn.UseVisualStyleBackColor = false;
            mngDeptbtn.Click += mngDeptbtn_Click;
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mngDeptbtn);
            Controls.Add(mngQues);
            Controls.Add(mngCrsBtn);
            Controls.Add(mngExamBtn);
            Location = new Point(277, 140);
            Margin = new Padding(0);
            Name = "Manage";
            Size = new Size(1176, 680);
            Load += Manage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button mngExamBtn;
        private Button mngCrsBtn;
        private Button mngQues;
        private Button mngDeptbtn;
    }
}
