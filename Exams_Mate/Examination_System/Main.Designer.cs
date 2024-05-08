namespace Examination_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            MinimBtn = new Button();
            CloseBtn = new Button();
            logoPicBx = new PictureBox();
            userNameTxtBx = new TextBox();
            label1 = new Label();
            PassTxtBx = new TextBox();
            label2 = new Label();
            logBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPicBx).BeginInit();
            SuspendLayout();
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
            MinimBtn.Location = new Point(542, 10);
            MinimBtn.Name = "MinimBtn";
            MinimBtn.Size = new Size(45, 46);
            MinimBtn.TabIndex = 13;
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
            CloseBtn.Location = new Point(593, 10);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(45, 46);
            CloseBtn.TabIndex = 12;
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // logoPicBx
            // 
            logoPicBx.Image = (Image)resources.GetObject("logoPicBx.Image");
            logoPicBx.Location = new Point(227, 32);
            logoPicBx.Name = "logoPicBx";
            logoPicBx.Size = new Size(187, 162);
            logoPicBx.SizeMode = PictureBoxSizeMode.Zoom;
            logoPicBx.TabIndex = 14;
            logoPicBx.TabStop = false;
            // 
            // userNameTxtBx
            // 
            userNameTxtBx.Cursor = Cursors.IBeam;
            userNameTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            userNameTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            userNameTxtBx.Location = new Point(265, 251);
            userNameTxtBx.Name = "userNameTxtBx";
            userNameTxtBx.Size = new Size(309, 37);
            userNameTxtBx.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(36, 251);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 24;
            label1.Text = "Username:";
            // 
            // PassTxtBx
            // 
            PassTxtBx.Cursor = Cursors.IBeam;
            PassTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            PassTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            PassTxtBx.Location = new Point(265, 320);
            PassTxtBx.Name = "PassTxtBx";
            PassTxtBx.PasswordChar = '*';
            PassTxtBx.Size = new Size(309, 37);
            PassTxtBx.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(36, 320);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 26;
            label2.Text = "Password:";
            // 
            // logBtn
            // 
            logBtn.BackColor = Color.FromArgb(58, 115, 193);
            logBtn.Cursor = Cursors.Hand;
            logBtn.FlatStyle = FlatStyle.Flat;
            logBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logBtn.ForeColor = Color.White;
            logBtn.Location = new Point(198, 390);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(257, 59);
            logBtn.TabIndex = 3;
            logBtn.Text = "Login";
            logBtn.UseVisualStyleBackColor = false;
            logBtn.Click += logBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(648, 478);
            Controls.Add(logBtn);
            Controls.Add(PassTxtBx);
            Controls.Add(label2);
            Controls.Add(userNameTxtBx);
            Controls.Add(label1);
            Controls.Add(logoPicBx);
            Controls.Add(MinimBtn);
            Controls.Add(CloseBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            MouseDown += Main_MouseDown;
            MouseMove += Main_MouseMove;
            MouseUp += Main_MouseUp;
            ((System.ComponentModel.ISupportInitialize)logoPicBx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button MinimBtn;
        private Button CloseBtn;
        private PictureBox logoPicBx;
        private TextBox userNameTxtBx;
        private Label label1;
        private TextBox PassTxtBx;
        private Label label2;
        private Button logBtn;
    }
}