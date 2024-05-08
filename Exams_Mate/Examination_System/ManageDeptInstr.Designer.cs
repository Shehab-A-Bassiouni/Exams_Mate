namespace Examination_System
{
    partial class ManageDeptInstr
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
            Editbtn = new Button();
            mngrComboBx = new ComboBox();
            label7 = new Label();
            deptDescripTxtBx = new RichTextBox();
            label6 = new Label();
            DeptNameTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DeptComboBx = new ComboBox();
            DelBtn = new Button();
            SuspendLayout();
            // 
            // Editbtn
            // 
            Editbtn.BackColor = Color.FromArgb(58, 115, 193);
            Editbtn.FlatStyle = FlatStyle.Flat;
            Editbtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Editbtn.ForeColor = Color.White;
            Editbtn.Location = new Point(200, 518);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(257, 59);
            Editbtn.TabIndex = 49;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // mngrComboBx
            // 
            mngrComboBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            mngrComboBx.ForeColor = Color.FromArgb(41, 39, 40);
            mngrComboBx.FormattingEnabled = true;
            mngrComboBx.Location = new Point(343, 197);
            mngrComboBx.Name = "mngrComboBx";
            mngrComboBx.Size = new Size(428, 36);
            mngrComboBx.TabIndex = 48;
            mngrComboBx.Click += mngrComboBx_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(178, 8, 55);
            label7.Location = new Point(34, 197);
            label7.Name = "label7";
            label7.Size = new Size(126, 28);
            label7.TabIndex = 47;
            label7.Text = "Manager:";
            // 
            // deptDescripTxtBx
            // 
            deptDescripTxtBx.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            deptDescripTxtBx.ForeColor = Color.FromArgb(41, 39, 40);
            deptDescripTxtBx.Location = new Point(343, 290);
            deptDescripTxtBx.Name = "deptDescripTxtBx";
            deptDescripTxtBx.Size = new Size(415, 94);
            deptDescripTxtBx.TabIndex = 46;
            deptDescripTxtBx.Text = "Enter Department Description..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(178, 8, 55);
            label6.Location = new Point(34, 286);
            label6.Name = "label6";
            label6.Size = new Size(149, 28);
            label6.TabIndex = 45;
            label6.Text = "Description:";
            // 
            // DeptNameTxtBox
            // 
            DeptNameTxtBox.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            DeptNameTxtBox.ForeColor = Color.FromArgb(41, 39, 40);
            DeptNameTxtBox.Location = new Point(343, 113);
            DeptNameTxtBox.Name = "DeptNameTxtBox";
            DeptNameTxtBox.Size = new Size(309, 37);
            DeptNameTxtBox.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(178, 8, 55);
            label1.Location = new Point(34, 116);
            label1.Name = "label1";
            label1.Size = new Size(236, 28);
            label1.TabIndex = 42;
            label1.Text = "Department Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(178, 8, 55);
            label2.Location = new Point(34, 45);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 41;
            label2.Text = "Department:";
            // 
            // DeptComboBx
            // 
            DeptComboBx.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            DeptComboBx.ForeColor = Color.FromArgb(41, 39, 40);
            DeptComboBx.FormattingEnabled = true;
            DeptComboBx.Location = new Point(343, 42);
            DeptComboBx.Name = "DeptComboBx";
            DeptComboBx.Size = new Size(428, 36);
            DeptComboBx.TabIndex = 50;
            DeptComboBx.SelectedIndexChanged += DeptComboBx_SelectedIndexChanged;
            DeptComboBx.Click += DeptComboBx_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.Maroon;
            DelBtn.FlatStyle = FlatStyle.Flat;
            DelBtn.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(645, 518);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(257, 59);
            DelBtn.TabIndex = 51;
            DelBtn.Text = "Delete";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // ManageDeptInstr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(DelBtn);
            Controls.Add(DeptComboBx);
            Controls.Add(Editbtn);
            Controls.Add(mngrComboBx);
            Controls.Add(label7);
            Controls.Add(deptDescripTxtBx);
            Controls.Add(label6);
            Controls.Add(DeptNameTxtBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(0);
            Name = "ManageDeptInstr";
            Size = new Size(1176, 680);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Editbtn;
        private ComboBox mngrComboBx;
        private Label label7;
        private RichTextBox deptDescripTxtBx;
        private Label label6;
        private TextBox DeptNameTxtBox;
        private Label label1;
        private Label label2;
        private ComboBox DeptComboBx;
        private Button DelBtn;
    }
}
