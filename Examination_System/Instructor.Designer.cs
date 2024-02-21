namespace Examination_System
{
    partial class Instructor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor));
            panel1 = new Panel();
            manageBtn = new Button();
            cpyright = new Label();
            AddCrsBtn = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            SidePanel = new Panel();
            AddQuesBtn = new Button();
            AddExamBtn = new Button();
            HomeBtn = new Button();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            InstructorHome = new PictureBox();
            CloseBtn = new Button();
            MinimBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InstructorHome).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(manageBtn);
            panel1.Controls.Add(cpyright);
            panel1.Controls.Add(AddCrsBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(AddQuesBtn);
            panel1.Controls.Add(AddExamBtn);
            panel1.Controls.Add(HomeBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 822);
            panel1.TabIndex = 4;
            // 
            // manageBtn
            // 
            manageBtn.FlatAppearance.BorderSize = 0;
            manageBtn.FlatStyle = FlatStyle.Flat;
            manageBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageBtn.ForeColor = Color.White;
            manageBtn.Image = (Image)resources.GetObject("manageBtn.Image");
            manageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageBtn.Location = new Point(12, 368);
            manageBtn.Name = "manageBtn";
            manageBtn.Size = new Size(256, 66);
            manageBtn.TabIndex = 13;
            manageBtn.Text = "     Manage";
            manageBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageBtn.UseVisualStyleBackColor = true;
            manageBtn.Click += manageBtn_Click;
            // 
            // cpyright
            // 
            cpyright.AutoSize = true;
            cpyright.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpyright.ForeColor = Color.White;
            cpyright.Location = new Point(12, 798);
            cpyright.Name = "cpyright";
            cpyright.Size = new Size(143, 16);
            cpyright.TabIndex = 10;
            cpyright.Text = "Copyright DB Team 4";
            // 
            // AddCrsBtn
            // 
            AddCrsBtn.FlatAppearance.BorderSize = 0;
            AddCrsBtn.FlatStyle = FlatStyle.Flat;
            AddCrsBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddCrsBtn.ForeColor = Color.White;
            AddCrsBtn.Image = (Image)resources.GetObject("AddCrsBtn.Image");
            AddCrsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddCrsBtn.Location = new Point(12, 296);
            AddCrsBtn.Name = "AddCrsBtn";
            AddCrsBtn.Size = new Size(256, 66);
            AddCrsBtn.TabIndex = 12;
            AddCrsBtn.Text = "     Add Course";
            AddCrsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddCrsBtn.UseVisualStyleBackColor = true;
            AddCrsBtn.Click += AddCrsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 20);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 10;
            label1.Text = "Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 698);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(178, 8, 55);
            SidePanel.Location = new Point(3, 80);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 66);
            SidePanel.TabIndex = 10;
            // 
            // AddQuesBtn
            // 
            AddQuesBtn.FlatAppearance.BorderSize = 0;
            AddQuesBtn.FlatStyle = FlatStyle.Flat;
            AddQuesBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddQuesBtn.ForeColor = Color.White;
            AddQuesBtn.Image = (Image)resources.GetObject("AddQuesBtn.Image");
            AddQuesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddQuesBtn.Location = new Point(12, 224);
            AddQuesBtn.Name = "AddQuesBtn";
            AddQuesBtn.Size = new Size(256, 66);
            AddQuesBtn.TabIndex = 5;
            AddQuesBtn.Text = "     Add Question";
            AddQuesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddQuesBtn.UseVisualStyleBackColor = true;
            AddQuesBtn.Click += AddQuesBtn_Click;
            // 
            // AddExamBtn
            // 
            AddExamBtn.FlatAppearance.BorderSize = 0;
            AddExamBtn.FlatStyle = FlatStyle.Flat;
            AddExamBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddExamBtn.ForeColor = Color.White;
            AddExamBtn.Image = (Image)resources.GetObject("AddExamBtn.Image");
            AddExamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddExamBtn.Location = new Point(12, 152);
            AddExamBtn.Name = "AddExamBtn";
            AddExamBtn.Size = new Size(256, 66);
            AddExamBtn.TabIndex = 4;
            AddExamBtn.Text = "     Add Exam";
            AddExamBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddExamBtn.UseVisualStyleBackColor = true;
            AddExamBtn.Click += AddExamBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Image = (Image)resources.GetObject("HomeBtn.Image");
            HomeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBtn.Location = new Point(12, 80);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(256, 66);
            HomeBtn.TabIndex = 3;
            HomeBtn.Text = "      Home";
            HomeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(354, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(110, 134);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(5, 104);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 4;
            label2.Text = "Exams Mate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1465, 10);
            panel2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(InstructorHome);
            panel4.Location = new Point(277, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(1176, 680);
            panel4.TabIndex = 7;
            // 
            // InstructorHome
            // 
            InstructorHome.Location = new Point(223, 22);
            InstructorHome.Name = "InstructorHome";
            InstructorHome.Size = new Size(743, 625);
            InstructorHome.SizeMode = PictureBoxSizeMode.Zoom;
            InstructorHome.TabIndex = 0;
            InstructorHome.TabStop = false;
            // 
            // CloseBtn
            // 
            CloseBtn.FlatAppearance.BorderColor = Color.White;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatAppearance.MouseDownBackColor = Color.White;
            CloseBtn.FlatAppearance.MouseOverBackColor = Color.White;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(1408, 16);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(45, 46);
            CloseBtn.TabIndex = 8;
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // MinimBtn
            // 
            MinimBtn.FlatAppearance.BorderColor = Color.White;
            MinimBtn.FlatAppearance.BorderSize = 0;
            MinimBtn.FlatAppearance.MouseDownBackColor = Color.White;
            MinimBtn.FlatAppearance.MouseOverBackColor = Color.White;
            MinimBtn.FlatStyle = FlatStyle.Flat;
            MinimBtn.Image = (Image)resources.GetObject("MinimBtn.Image");
            MinimBtn.Location = new Point(1357, 16);
            MinimBtn.Name = "MinimBtn";
            MinimBtn.Size = new Size(45, 46);
            MinimBtn.TabIndex = 9;
            MinimBtn.UseVisualStyleBackColor = true;
            MinimBtn.Click += MinimBtn_Click;
            // 
            // Instructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1465, 832);
            Controls.Add(MinimBtn);
            Controls.Add(CloseBtn);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Instructor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor";
            Load += Instructor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InstructorHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddQuesBtn;
        private Button AddExamBtn;
        private Button HomeBtn;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel4;
        private Button CloseBtn;
        private Button MinimBtn;
        private PictureBox InstructorHome;
        private Panel SidePanel;
        private Label label1;
        private PictureBox pictureBox2;
        private Button AddCrsBtn;
        private Label cpyright;
        private Button manageBtn;
    }
}