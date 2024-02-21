namespace Examination_System
{
    partial class AddQues
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
            CrsIDCombo = new ComboBox();
            AddBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            QuesIdTxtBx = new TextBox();
            McqQRad = new RadioButton();
            TFQRad = new RadioButton();
            label4 = new Label();
            QContentTxtBx = new RichTextBox();
            label5 = new Label();
            Opt1TxtBx = new RichTextBox();
            Opt2TxtBx = new RichTextBox();
            Opt3TxtBx = new RichTextBox();
            Opt4TxtBx = new RichTextBox();
            label6 = new Label();
            CrctAnsCombo = new ComboBox();
            OptionsPanel = new Panel();
            OptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CrsIDCombo
            // 
            CrsIDCombo.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            CrsIDCombo.ForeColor = Color.FromArgb(41, 39, 40);
            CrsIDCombo.FormattingEnabled = true;
            CrsIDCombo.Location = new Point(427, 113);
            CrsIDCombo.Name = "CrsIDCombo";
            CrsIDCombo.Size = new Size(309, 36);
            CrsIDCombo.TabIndex = 28;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(58, 115, 193);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(479, 605);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(257, 59);
            AddBtn.TabIndex = 22;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(178, 8, 55);
            label3.Location = new Point(75, 192);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 17;
            label3.Text = "Question Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(75, 113);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 16;
            label2.Text = "Course ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(75, 32);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 15;
            label1.Text = "Question ID:";
            // 
            // QuesIdTxtBx
            // 
            QuesIdTxtBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            QuesIdTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            QuesIdTxtBx.Location = new Point(427, 32);
            QuesIdTxtBx.Name = "QuesIdTxtBx";
            QuesIdTxtBx.ReadOnly = true;
            QuesIdTxtBx.Size = new Size(309, 37);
            QuesIdTxtBx.TabIndex = 23;
            // 
            // McqQRad
            // 
            McqQRad.AutoSize = true;
            McqQRad.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            McqQRad.ForeColor = Color.FromArgb(41, 39, 40);
            McqQRad.Location = new Point(427, 192);
            McqQRad.Name = "McqQRad";
            McqQRad.Size = new Size(91, 32);
            McqQRad.TabIndex = 30;
            McqQRad.TabStop = true;
            McqQRad.Text = "MCQ";
            McqQRad.UseVisualStyleBackColor = true;
            McqQRad.Click += McqQRad_Click;
            // 
            // TFQRad
            // 
            TFQRad.AutoSize = true;
            TFQRad.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            TFQRad.ForeColor = Color.FromArgb(41, 39, 40);
            TFQRad.Location = new Point(577, 192);
            TFQRad.Name = "TFQRad";
            TFQRad.Size = new Size(152, 32);
            TFQRad.TabIndex = 31;
            TFQRad.TabStop = true;
            TFQRad.Text = "True\\False";
            TFQRad.UseVisualStyleBackColor = true;
            TFQRad.Click += TFQRad_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(178, 8, 55);
            label4.Location = new Point(75, 303);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 32;
            label4.Text = "Content:";
            // 
            // QContentTxtBx
            // 
            QContentTxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            QContentTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            QContentTxtBx.Location = new Point(228, 303);
            QContentTxtBx.Name = "QContentTxtBx";
            QContentTxtBx.Size = new Size(415, 94);
            QContentTxtBx.TabIndex = 33;
            QContentTxtBx.Text = "Enter Question Content..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(178, 8, 55);
            label5.Location = new Point(42, 54);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 34;
            label5.Text = "Options:";
            label5.Click += label5_Click;
            // 
            // Opt1TxtBx
            // 
            Opt1TxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Opt1TxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            Opt1TxtBx.Location = new Point(210, 16);
            Opt1TxtBx.Name = "Opt1TxtBx";
            Opt1TxtBx.Size = new Size(172, 132);
            Opt1TxtBx.TabIndex = 35;
            Opt1TxtBx.Text = "Option 1 ..";
            // 
            // Opt2TxtBx
            // 
            Opt2TxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Opt2TxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            Opt2TxtBx.Location = new Point(416, 16);
            Opt2TxtBx.Name = "Opt2TxtBx";
            Opt2TxtBx.Size = new Size(180, 132);
            Opt2TxtBx.TabIndex = 36;
            Opt2TxtBx.Text = "Option 2 ..";
            // 
            // Opt3TxtBx
            // 
            Opt3TxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Opt3TxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            Opt3TxtBx.Location = new Point(627, 16);
            Opt3TxtBx.Name = "Opt3TxtBx";
            Opt3TxtBx.Size = new Size(176, 132);
            Opt3TxtBx.TabIndex = 37;
            Opt3TxtBx.Text = "Option 3 ..";
            // 
            // Opt4TxtBx
            // 
            Opt4TxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Opt4TxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            Opt4TxtBx.Location = new Point(836, 16);
            Opt4TxtBx.Name = "Opt4TxtBx";
            Opt4TxtBx.Size = new Size(182, 132);
            Opt4TxtBx.TabIndex = 38;
            Opt4TxtBx.Text = "Option 4 ..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(685, 303);
            label6.Name = "label6";
            label6.Size = new Size(198, 28);
            label6.TabIndex = 39;
            label6.Text = "Correct Answer:";
            // 
            // CrctAnsCombo
            // 
            CrctAnsCombo.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            CrctAnsCombo.ForeColor = Color.FromArgb(41, 39, 40);
            CrctAnsCombo.FormattingEnabled = true;
            CrctAnsCombo.Location = new Point(685, 334);
            CrctAnsCombo.Name = "CrctAnsCombo";
            CrctAnsCombo.Size = new Size(309, 36);
            CrctAnsCombo.TabIndex = 40;
            // 
            // OptionsPanel
            // 
            OptionsPanel.Controls.Add(label5);
            OptionsPanel.Controls.Add(Opt4TxtBx);
            OptionsPanel.Controls.Add(Opt3TxtBx);
            OptionsPanel.Controls.Add(Opt1TxtBx);
            OptionsPanel.Controls.Add(Opt2TxtBx);
            OptionsPanel.Location = new Point(75, 426);
            OptionsPanel.Name = "OptionsPanel";
            OptionsPanel.Size = new Size(1030, 157);
            OptionsPanel.TabIndex = 41;
            // 
            // AddQues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(OptionsPanel);
            Controls.Add(CrctAnsCombo);
            Controls.Add(label6);
            Controls.Add(QContentTxtBx);
            Controls.Add(label4);
            Controls.Add(TFQRad);
            Controls.Add(McqQRad);
            Controls.Add(CrsIDCombo);
            Controls.Add(QuesIdTxtBx);
            Controls.Add(AddBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(277, 140);
            Name = "AddQues";
            Size = new Size(1176, 680);
            Load += AddQues_Load;
            OptionsPanel.ResumeLayout(false);
            OptionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CrsIDCombo;
        private Button AddBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox QuesIdTxtBx;
        private RadioButton McqQRad;
        private RadioButton TFQRad;
        private Label label4;
        private RichTextBox QContentTxtBx;
        private Label label5;
        private RichTextBox Opt1TxtBx;
        private RichTextBox Opt2TxtBx;
        private RichTextBox Opt3TxtBx;
        private RichTextBox Opt4TxtBx;
        private Label label6;
        private ComboBox CrctAnsCombo;
        private Panel OptionsPanel;
    }
}
