namespace Examination_System
{
    partial class Student
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panel1 = new Panel();
            cpyright = new Label();
            pictureBox2 = new PictureBox();
            SidePanel = new Panel();
            label1 = new Label();
            joinbtn = new Button();
            slvBtn = new Button();
            homeBtn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            MinimBtn = new Button();
            CloseBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(cpyright);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(joinbtn);
            panel1.Controls.Add(slvBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 832);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cpyright
            // 
            cpyright.AutoSize = true;
            cpyright.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpyright.ForeColor = Color.White;
            cpyright.Location = new Point(12, 809);
            cpyright.Name = "cpyright";
            cpyright.Size = new Size(143, 16);
            cpyright.TabIndex = 13;
            cpyright.Text = "Copyright DB Team 4";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 709);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(178, 8, 55);
            SidePanel.Location = new Point(3, 93);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 66);
            SidePanel.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 11;
            label1.Text = "Dashboard";
            // 
            // joinbtn
            // 
            joinbtn.Cursor = Cursors.Hand;
            joinbtn.FlatAppearance.BorderSize = 0;
            joinbtn.FlatStyle = FlatStyle.Flat;
            joinbtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            joinbtn.Image = (Image)resources.GetObject("joinbtn.Image");
            joinbtn.ImageAlign = ContentAlignment.MiddleLeft;
            joinbtn.Location = new Point(15, 237);
            joinbtn.Name = "joinbtn";
            joinbtn.Size = new Size(256, 66);
            joinbtn.TabIndex = 8;
            joinbtn.Text = "        Join Course";
            joinbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            joinbtn.UseVisualStyleBackColor = true;
            joinbtn.Click += joinbtn_Click;
            // 
            // slvBtn
            // 
            slvBtn.Cursor = Cursors.Hand;
            slvBtn.FlatAppearance.BorderSize = 0;
            slvBtn.FlatStyle = FlatStyle.Flat;
            slvBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slvBtn.Image = (Image)resources.GetObject("slvBtn.Image");
            slvBtn.ImageAlign = ContentAlignment.MiddleLeft;
            slvBtn.Location = new Point(15, 165);
            slvBtn.Name = "slvBtn";
            slvBtn.Size = new Size(256, 66);
            slvBtn.TabIndex = 7;
            slvBtn.Text = "        Solve Exam";
            slvBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            slvBtn.UseVisualStyleBackColor = true;
            slvBtn.Click += slvBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(15, 93);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(256, 66);
            homeBtn.TabIndex = 3;
            homeBtn.Text = "        Home";
            homeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(271, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1194, 10);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(354, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(110, 134);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 104);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 4;
            label2.Text = "Exams Mate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            MinimBtn.Location = new Point(1357, 12);
            MinimBtn.Name = "MinimBtn";
            MinimBtn.Size = new Size(45, 46);
            MinimBtn.TabIndex = 11;
            MinimBtn.UseVisualStyleBackColor = true;
            MinimBtn.Click += MinimBtn_Click;
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
            CloseBtn.Location = new Point(1408, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(45, 46);
            CloseBtn.TabIndex = 10;
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1465, 832);
            Controls.Add(MinimBtn);
            Controls.Add(CloseBtn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.SizeAll;
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Student_Load;
            MouseDown += Student_MouseDown;
            MouseMove += Student_MouseMove;
            MouseUp += Student_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private Button homeBtn;
        private Button joinbtn;
        private Button slvBtn;
        private Label label1;
        private Panel SidePanel;
        private Label cpyright;
        private PictureBox pictureBox2;
        private Button MinimBtn;
        private Button CloseBtn;
    }
}
