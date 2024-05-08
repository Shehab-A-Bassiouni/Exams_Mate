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
            deptBtn = new Button();
            rprtsBtn = new Button();
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
            logoPicBx = new PictureBox();
            panel2 = new Panel();
            CloseBtn = new Button();
            MinimBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPicBx).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(deptBtn);
            panel1.Controls.Add(rprtsBtn);
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
            panel1.Size = new Size(271, 815);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // deptBtn
            // 
            deptBtn.Cursor = Cursors.Hand;
            deptBtn.FlatAppearance.BorderSize = 0;
            deptBtn.FlatStyle = FlatStyle.Flat;
            deptBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deptBtn.ForeColor = Color.White;
            deptBtn.Image = (Image)resources.GetObject("deptBtn.Image");
            deptBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deptBtn.Location = new Point(15, 368);
            deptBtn.Name = "deptBtn";
            deptBtn.Size = new Size(256, 66);
            deptBtn.TabIndex = 15;
            deptBtn.Text = "     Add Department";
            deptBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deptBtn.UseVisualStyleBackColor = true;
            deptBtn.Click += deptBtn_Click;
            // 
            // rprtsBtn
            // 
            rprtsBtn.Cursor = Cursors.Hand;
            rprtsBtn.FlatAppearance.BorderSize = 0;
            rprtsBtn.FlatStyle = FlatStyle.Flat;
            rprtsBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rprtsBtn.ForeColor = Color.White;
            rprtsBtn.Image = (Image)resources.GetObject("rprtsBtn.Image");
            rprtsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            rprtsBtn.Location = new Point(12, 512);
            rprtsBtn.Name = "rprtsBtn";
            rprtsBtn.Size = new Size(256, 66);
            rprtsBtn.TabIndex = 14;
            rprtsBtn.Text = "     Reports";
            rprtsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            rprtsBtn.UseVisualStyleBackColor = true;
            rprtsBtn.Click += rprtsBtn_Click;
            // 
            // manageBtn
            // 
            manageBtn.Cursor = Cursors.Hand;
            manageBtn.FlatAppearance.BorderSize = 0;
            manageBtn.FlatStyle = FlatStyle.Flat;
            manageBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageBtn.ForeColor = Color.White;
            manageBtn.Image = (Image)resources.GetObject("manageBtn.Image");
            manageBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageBtn.Location = new Point(15, 440);
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
            AddCrsBtn.Cursor = Cursors.Hand;
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
            pictureBox2.Location = new Point(12, 673);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 122);
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
            AddQuesBtn.Cursor = Cursors.Hand;
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
            AddExamBtn.Cursor = Cursors.Hand;
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
            HomeBtn.Cursor = Cursors.Hand;
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
            panel3.Controls.Add(logoPicBx);
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
            // logoPicBx
            // 
            logoPicBx.Image = (Image)resources.GetObject("logoPicBx.Image");
            logoPicBx.Location = new Point(3, 12);
            logoPicBx.Name = "logoPicBx";
            logoPicBx.Size = new Size(103, 89);
            logoPicBx.SizeMode = PictureBoxSizeMode.Zoom;
            logoPicBx.TabIndex = 0;
            logoPicBx.TabStop = false;
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
            // CloseBtn
            // 
            CloseBtn.Cursor = Cursors.Hand;
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
            MinimBtn.Cursor = Cursors.Hand;
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
            ClientSize = new Size(1465, 825);
            Controls.Add(MinimBtn);
            Controls.Add(CloseBtn);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Cursor = Cursors.SizeAll;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Instructor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor";
            Load += Instructor_Load;
            MouseDown += Instructor_MouseDown;
            MouseMove += Instructor_MouseMove;
            MouseUp += Instructor_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPicBx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddQuesBtn;
        private Button AddExamBtn;
        private Button HomeBtn;
        private Panel panel3;
        private Label label2;
        private PictureBox logoPicBx;
        private Panel panel2;
        private Button CloseBtn;
        private Button MinimBtn;
        private Panel SidePanel;
        private Label label1;
        private PictureBox pictureBox2;
        private Button AddCrsBtn;
        private Label cpyright;
        private Button manageBtn;
        private Button rprtsBtn;
        private Button deptBtn;
    }
}