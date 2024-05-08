namespace Examination_System
{
    partial class AddDeptCtrl
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
            DeptNameTxtBox = new TextBox();
            label1 = new Label();
            deptDescripTxtBx = new RichTextBox();
            label6 = new Label();
            mngrComboBx = new ComboBox();
            label7 = new Label();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // DeptNameTxtBox
            // 
            DeptNameTxtBox.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            DeptNameTxtBox.ForeColor = Color.FromArgb(41, 39, 40);
            DeptNameTxtBox.Location = new Point(373, 97);
            DeptNameTxtBox.Name = "DeptNameTxtBox";
            DeptNameTxtBox.Size = new Size(309, 37);
            DeptNameTxtBox.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(64, 100);
            label1.Name = "label1";
            label1.Size = new Size(236, 28);
            label1.TabIndex = 27;
            label1.Text = "Department Name:";
            // 
            // deptDescripTxtBx
            // 
            deptDescripTxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            deptDescripTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            deptDescripTxtBx.Location = new Point(373, 274);
            deptDescripTxtBx.Name = "deptDescripTxtBx";
            deptDescripTxtBx.Size = new Size(415, 94);
            deptDescripTxtBx.TabIndex = 36;
            deptDescripTxtBx.Text = "Enter Department Description..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(64, 270);
            label6.Name = "label6";
            label6.Size = new Size(149, 28);
            label6.TabIndex = 35;
            label6.Text = "Description:";
            // 
            // mngrComboBx
            // 
            mngrComboBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            mngrComboBx.ForeColor = Color.FromArgb(41, 39, 40);
            mngrComboBx.FormattingEnabled = true;
            mngrComboBx.Location = new Point(373, 181);
            mngrComboBx.Name = "mngrComboBx";
            mngrComboBx.Size = new Size(428, 36);
            mngrComboBx.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(178, 8, 55);
            label7.Location = new Point(64, 181);
            label7.Name = "label7";
            label7.Size = new Size(126, 28);
            label7.TabIndex = 38;
            label7.Text = "Manager:";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(58, 115, 193);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(415, 496);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(257, 59);
            AddBtn.TabIndex = 40;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddDeptCtrl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(AddBtn);
            Controls.Add(mngrComboBx);
            Controls.Add(label7);
            Controls.Add(deptDescripTxtBx);
            Controls.Add(label6);
            Controls.Add(DeptNameTxtBox);
            Controls.Add(label1);
            Location = new Point(277, 140);
            Margin = new Padding(0);
            Name = "AddDeptCtrl";
            Size = new Size(1176, 680);
            Load += AddDeptCtrl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DeptNameTxtBox;
        private Label label1;
        private RichTextBox deptDescripTxtBx;
        private Label label6;
        private ComboBox mngrComboBx;
        private Label label7;
        private Button AddBtn;
    }
}
