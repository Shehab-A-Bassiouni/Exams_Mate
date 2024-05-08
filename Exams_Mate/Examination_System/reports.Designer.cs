namespace Examination_System
{
    partial class reports
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            numericParam1 = new NumericUpDown();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            getToolStripMenuItem = new ToolStripMenuItem();
            getQuestionsAndAnswersInExamToolStripMenuItem = new ToolStripMenuItem();
            getStudentGradesToolStripMenuItem = new ToolStripMenuItem();
            getStudentInformationInDepartmentToolStripMenuItem = new ToolStripMenuItem();
            getTopicsInCourseToolStripMenuItem = new ToolStripMenuItem();
            getStudentAnswerInExamToolStripMenuItem = new ToolStripMenuItem();
            btnGenerate1 = new Button();
            btnGenerate2 = new Button();
            btnGenerate6 = new Button();
            btnGenerate5 = new Button();
            btnGenerate4 = new Button();
            btnGenerate3 = new Button();
            numericParam2 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericParam1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericParam2).BeginInit();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.LocalReport.DisplayName = "GetCrsNameAndStdNumByInsId.rdlc";
            reportViewer1.Location = new Point(0, 75);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1000, 600);
            reportViewer1.TabIndex = 0;
            reportViewer1.Load += reportViewer1_Load;
            // 
            // numericParam1
            // 
            numericParam1.Location = new Point(112, 37);
            numericParam1.Name = "numericParam1";
            numericParam1.Size = new Size(130, 23);
            numericParam1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 41);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "Instructor ID:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { getToolStripMenuItem, getQuestionsAndAnswersInExamToolStripMenuItem, getStudentGradesToolStripMenuItem, getStudentInformationInDepartmentToolStripMenuItem, getTopicsInCourseToolStripMenuItem, getStudentAnswerInExamToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1176, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // getToolStripMenuItem
            // 
            getToolStripMenuItem.Name = "getToolStripMenuItem";
            getToolStripMenuItem.Size = new Size(231, 20);
            getToolStripMenuItem.Text = "Get Course Name and Student Numbers";
            getToolStripMenuItem.Click += getToolStripMenuItem_Click;
            // 
            // getQuestionsAndAnswersInExamToolStripMenuItem
            // 
            getQuestionsAndAnswersInExamToolStripMenuItem.Name = "getQuestionsAndAnswersInExamToolStripMenuItem";
            getQuestionsAndAnswersInExamToolStripMenuItem.Size = new Size(210, 20);
            getQuestionsAndAnswersInExamToolStripMenuItem.Text = "Get Questions And Answers In Exam";
            getQuestionsAndAnswersInExamToolStripMenuItem.Click += getQuestionsAndAnswersInExamToolStripMenuItem_Click;
            // 
            // getStudentGradesToolStripMenuItem
            // 
            getStudentGradesToolStripMenuItem.Name = "getStudentGradesToolStripMenuItem";
            getStudentGradesToolStripMenuItem.Size = new Size(120, 20);
            getStudentGradesToolStripMenuItem.Text = "Get Student Grades";
            getStudentGradesToolStripMenuItem.Click += getStudentGradesToolStripMenuItem_Click;
            // 
            // getStudentInformationInDepartmentToolStripMenuItem
            // 
            getStudentInformationInDepartmentToolStripMenuItem.Name = "getStudentInformationInDepartmentToolStripMenuItem";
            getStudentInformationInDepartmentToolStripMenuItem.Size = new Size(226, 20);
            getStudentInformationInDepartmentToolStripMenuItem.Text = "Get Student Information In Department";
            getStudentInformationInDepartmentToolStripMenuItem.Click += getStudentInformationInDepartmentToolStripMenuItem_Click;
            // 
            // getTopicsInCourseToolStripMenuItem
            // 
            getTopicsInCourseToolStripMenuItem.Name = "getTopicsInCourseToolStripMenuItem";
            getTopicsInCourseToolStripMenuItem.Size = new Size(126, 20);
            getTopicsInCourseToolStripMenuItem.Text = "Get Topics in Course";
            getTopicsInCourseToolStripMenuItem.Click += getTopicsInCourseToolStripMenuItem_Click;
            // 
            // getStudentAnswerInExamToolStripMenuItem
            // 
            getStudentAnswerInExamToolStripMenuItem.Name = "getStudentAnswerInExamToolStripMenuItem";
            getStudentAnswerInExamToolStripMenuItem.Size = new Size(168, 20);
            getStudentAnswerInExamToolStripMenuItem.Text = "Get Student Answer In Exam";
            getStudentAnswerInExamToolStripMenuItem.Click += getStudentAnswerInExamToolStripMenuItem_Click;
            // 
            // btnGenerate1
            // 
            btnGenerate1.Location = new Point(251, 37);
            btnGenerate1.Name = "btnGenerate1";
            btnGenerate1.Size = new Size(117, 23);
            btnGenerate1.TabIndex = 1;
            btnGenerate1.Text = "Generate";
            btnGenerate1.UseVisualStyleBackColor = true;
            btnGenerate1.Click += btnGenerate1_Click;
            // 
            // btnGenerate2
            // 
            btnGenerate2.Location = new Point(251, 37);
            btnGenerate2.Name = "btnGenerate2";
            btnGenerate2.Size = new Size(117, 23);
            btnGenerate2.TabIndex = 7;
            btnGenerate2.Text = "Generate";
            btnGenerate2.UseVisualStyleBackColor = true;
            btnGenerate2.Click += btnGenerate2_Click;
            // 
            // btnGenerate6
            // 
            btnGenerate6.Location = new Point(525, 37);
            btnGenerate6.Name = "btnGenerate6";
            btnGenerate6.Size = new Size(117, 23);
            btnGenerate6.TabIndex = 8;
            btnGenerate6.Text = "Generate";
            btnGenerate6.UseVisualStyleBackColor = true;
            btnGenerate6.Click += btnGenerate6_Click;
            // 
            // btnGenerate5
            // 
            btnGenerate5.Location = new Point(251, 37);
            btnGenerate5.Name = "btnGenerate5";
            btnGenerate5.Size = new Size(117, 23);
            btnGenerate5.TabIndex = 9;
            btnGenerate5.Text = "Generate";
            btnGenerate5.UseVisualStyleBackColor = true;
            btnGenerate5.Click += btnGenerate5_Click;
            // 
            // btnGenerate4
            // 
            btnGenerate4.Location = new Point(251, 37);
            btnGenerate4.Name = "btnGenerate4";
            btnGenerate4.Size = new Size(117, 23);
            btnGenerate4.TabIndex = 10;
            btnGenerate4.Text = "Generate";
            btnGenerate4.UseVisualStyleBackColor = true;
            btnGenerate4.Click += btnGenerate4_Click;
            // 
            // btnGenerate3
            // 
            btnGenerate3.Location = new Point(251, 37);
            btnGenerate3.Name = "btnGenerate3";
            btnGenerate3.Size = new Size(117, 23);
            btnGenerate3.TabIndex = 11;
            btnGenerate3.Text = "Generate";
            btnGenerate3.UseVisualStyleBackColor = true;
            btnGenerate3.Click += btnGenerate3_Click;
            // 
            // numericParam2
            // 
            numericParam2.Location = new Point(374, 37);
            numericParam2.Name = "numericParam2";
            numericParam2.Size = new Size(130, 23);
            numericParam2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 41);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 16;
            label1.Text = "Exam Number:";
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(numericParam2);
            Controls.Add(btnGenerate3);
            Controls.Add(btnGenerate4);
            Controls.Add(btnGenerate5);
            Controls.Add(btnGenerate6);
            Controls.Add(btnGenerate2);
            Controls.Add(label2);
            Controls.Add(numericParam1);
            Controls.Add(btnGenerate1);
            Controls.Add(reportViewer1);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Location = new Point(277, 140);
            Name = "reports";
            Size = new Size(1176, 680);
            Load += reports_Load;
            ((System.ComponentModel.ISupportInitialize)numericParam1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericParam2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private NumericUpDown numericParam1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem getToolStripMenuItem;
        private Button btnGenerate1;
        private Button btnGenerate2;
        private Button btnGenerate6;
        private Button btnGenerate5;
        private Button btnGenerate4;
        private Button btnGenerate3;
        private ToolStripMenuItem getQuestionsAndAnswersInExamToolStripMenuItem;
        private ToolStripMenuItem getStudentGradesToolStripMenuItem;
        private ToolStripMenuItem getStudentInformationInDepartmentToolStripMenuItem;
        private ToolStripMenuItem getTopicsInCourseToolStripMenuItem;
        private ToolStripMenuItem getStudentAnswerInExamToolStripMenuItem;
        private NumericUpDown numericParam2;
        private Label label1;
    }
}
