namespace Examination_System
{
    partial class slvStud
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
            exmComboBx = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PassGradeTxtBx = new TextBox();
            DurationTxtBx = new TextBox();
            button1 = new Button();
            crsComboBx = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // exmComboBx
            // 
            exmComboBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            exmComboBx.ForeColor = Color.FromArgb(41, 39, 40);
            exmComboBx.FormattingEnabled = true;
            exmComboBx.Location = new Point(449, 141);
            exmComboBx.Name = "exmComboBx";
            exmComboBx.Size = new Size(309, 36);
            exmComboBx.TabIndex = 21;
            exmComboBx.SelectedIndexChanged += exmComboBx_SelectedIndexChanged;
            exmComboBx.Click += exmComboBx_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(323, 144);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 20;
            label2.Text = "Exam:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(178, 8, 55);
            label3.Location = new Point(41, 246);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 23;
            label3.Text = "Passing Grade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(41, 328);
            label4.Name = "label4";
            label4.Size = new Size(239, 28);
            label4.TabIndex = 24;
            label4.Text = "Duration in Minutes:";
            // 
            // PassGradeTxtBx
            // 
            PassGradeTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            PassGradeTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            PassGradeTxtBx.Location = new Point(357, 237);
            PassGradeTxtBx.Margin = new Padding(3, 2, 3, 2);
            PassGradeTxtBx.Name = "PassGradeTxtBx";
            PassGradeTxtBx.ReadOnly = true;
            PassGradeTxtBx.Size = new Size(309, 37);
            PassGradeTxtBx.TabIndex = 42;
            // 
            // DurationTxtBx
            // 
            DurationTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            DurationTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            DurationTxtBx.Location = new Point(357, 328);
            DurationTxtBx.Margin = new Padding(3, 2, 3, 2);
            DurationTxtBx.Name = "DurationTxtBx";
            DurationTxtBx.ReadOnly = true;
            DurationTxtBx.Size = new Size(309, 37);
            DurationTxtBx.TabIndex = 44;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(58, 115, 193);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(459, 505);
            button1.Name = "button1";
            button1.Size = new Size(257, 59);
            button1.TabIndex = 45;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // crsComboBx
            // 
            crsComboBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            crsComboBx.ForeColor = Color.FromArgb(41, 39, 40);
            crsComboBx.FormattingEnabled = true;
            crsComboBx.Location = new Point(449, 82);
            crsComboBx.Name = "crsComboBx";
            crsComboBx.Size = new Size(309, 36);
            crsComboBx.TabIndex = 47;
            crsComboBx.SelectedIndexChanged += crsComboBx_SelectedIndexChanged;
            crsComboBx.Click += crsComboBx_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(323, 85);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 46;
            label6.Text = "Course:";
            // 
            // slvStud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(crsComboBx);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(DurationTxtBx);
            Controls.Add(PassGradeTxtBx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(exmComboBx);
            Controls.Add(label2);
            Location = new Point(277, 140);
            Margin = new Padding(0);
            Name = "slvStud";
            Size = new Size(1176, 680);
            Load += slvStud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox exmComboBx;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PassGradeTxtBx;
        private TextBox DurationTxtBx;
        private Button button1;
        private ComboBox crsComboBx;
        private Label label6;
    }
}
