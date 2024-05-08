using Examination_System.Managers;
using Examination_System.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examination_System
{
	public partial class AddQues : UserControl
	{
		string[] optionTxtBx_PlaceHolder;

		ITI_Exam_SystemContext context = new();
		public AddQues()
		{
			InitializeComponent();
			optionTxtBx_PlaceHolder = ["Option 1 ..", "Option 2 ..", "Option 3 ..", "Option 4 ..", "Enter Question Content.."];
			OptionsTxtBxAttachEvents();
			OptionsPanel.Visible = false;



		}



		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void McqQRad_Click(object sender, EventArgs e)
		{
			OptionsPanel.Visible = true;
			this.CrctAnsCombo.Items.Clear();
			this.CrctAnsCombo.Items.Add("Option 1");
			this.CrctAnsCombo.Items.Add("Option 2");
			this.CrctAnsCombo.Items.Add("Option 3");
			this.CrctAnsCombo.Items.Add("Option 4");

		}

		private void AddQues_Load(object sender, EventArgs e)
		{
			load_crs_comboBox();
		}

		private void OptionsTxtBxAttachEvents()
		{
			this.Opt1TxtBx.GotFocus += OptionsTxtBx_GotFocus;
			this.Opt2TxtBx.GotFocus += OptionsTxtBx_GotFocus;
			this.Opt3TxtBx.GotFocus += OptionsTxtBx_GotFocus;
			this.Opt4TxtBx.GotFocus += OptionsTxtBx_GotFocus;
			this.QContentTxtBx.GotFocus += OptionsTxtBx_GotFocus;

			this.Opt1TxtBx.LostFocus += OptionsTxtBx_LostFocus;
			this.Opt2TxtBx.LostFocus += OptionsTxtBx_LostFocus;
			this.Opt3TxtBx.LostFocus += OptionsTxtBx_LostFocus;
			this.Opt4TxtBx.LostFocus += OptionsTxtBx_LostFocus;
			this.QContentTxtBx.LostFocus += OptionsTxtBx_LostFocus;



		}

		private void OptionsTxtBx_GotFocus(object sender, EventArgs e)
		{
			if (this.Opt1TxtBx.Text == optionTxtBx_PlaceHolder[0])
			{
				this.Opt1TxtBx.Text = "";
			}

			if (this.Opt2TxtBx.Text == optionTxtBx_PlaceHolder[1])
			{
				this.Opt2TxtBx.Text = "";
			}

			if (this.Opt3TxtBx.Text == optionTxtBx_PlaceHolder[2])
			{
				this.Opt3TxtBx.Text = "";
			}

			if (this.Opt4TxtBx.Text == optionTxtBx_PlaceHolder[3])
			{
				this.Opt4TxtBx.Text = "";
			}
			if (this.QContentTxtBx.Text == optionTxtBx_PlaceHolder[4])
			{
				this.QContentTxtBx.Text = "";
			}
		}

		private void OptionsTxtBx_LostFocus(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(this.Opt1TxtBx.Text))
			{
				this.Opt1TxtBx.Text = optionTxtBx_PlaceHolder[0];
			}

			if (string.IsNullOrWhiteSpace(this.Opt2TxtBx.Text))
			{
				this.Opt2TxtBx.Text = optionTxtBx_PlaceHolder[1];
			}

			if (string.IsNullOrWhiteSpace(this.Opt3TxtBx.Text))
			{
				this.Opt3TxtBx.Text = optionTxtBx_PlaceHolder[2];
			}

			if (string.IsNullOrWhiteSpace(this.Opt4TxtBx.Text))
			{
				this.Opt4TxtBx.Text = optionTxtBx_PlaceHolder[3];
			}

			if (string.IsNullOrWhiteSpace(this.QContentTxtBx.Text))
			{
				this.QContentTxtBx.Text = optionTxtBx_PlaceHolder[4];
			}
		}

		private void TFQRad_Click(object sender, EventArgs e)
		{
			OptionsPanel.Visible = false;
			this.CrctAnsCombo.Items.Clear();
			this.CrctAnsCombo.Items.Add("True");
			this.CrctAnsCombo.Items.Add("False");
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			int crs_id = InstructorsManager.Instructor_Courses.FirstOrDefault(item => item.CrsName == this.CrsIDCombo.Text).CrsId;
			string content = this.QContentTxtBx.Text;
			int points = (int)this.numericPoints.Value;
			int correct_answ = 0;
			List<string> options = new() { this.Opt1TxtBx.Text, this.Opt2TxtBx.Text, this.Opt3TxtBx.Text, this.Opt4TxtBx.Text };
			if (this.TFQRad.Checked) {
                correct_answ= CrctAnsCombo.Text == "True" ? 1 : 0;
                InstructorsManager.Add_Ques_TF(crs_id,content,points,correct_answ);
				success succ1 = new("Added");
				this.Controls.Add(succ1);
				succ1.BringToFront();
			}

			if (this.McqQRad.Checked) {
				if (this.CrctAnsCombo.Text == "Option 1") correct_answ = 1;
				else if (this.CrctAnsCombo.Text == "Option 2") correct_answ = 2;
				else if (this.CrctAnsCombo.Text == "Option 3") correct_answ = 3;
				else if (this.CrctAnsCombo.Text == "Option 4") correct_answ = 4;
                InstructorsManager.Add_Ques_MCQ(crs_id, content, points, correct_answ,options);
				success succ2 = new("Added");
				this.Controls.Add(succ2);
				succ2.BringToFront();
			}
		}
		private void load_crs_comboBox()
		{
			var Crs = InstructorsManager.Get_Instructor_Courses();

			foreach (var item in Crs)
			{
				this.CrsIDCombo.Items.Add(item.CrsName);
			}
		}

	}
}
