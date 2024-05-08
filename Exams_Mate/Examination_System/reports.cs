using Microsoft.Reporting.WinForms;
//using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Examination_System.DataSet1TableAdapters;
using Examination_System.Managers;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Examination_System
{
    public partial class reports : UserControl
    {
        DataTable dataTable;


        public reports()
        {
            InitializeComponent();
            dataTable = new DataTable();

        }

        private void HideAllButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button || control is NumericUpDown || control is Label)
                {
                    control.Hide();
                }
            }
        }

        private void reports_Load(object sender, EventArgs e)
        {
            HideAllButtons();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            btnGenerate1.Show();
            numericParam1.Show();
            label2.Show();
        }

        private void getQuestionsAndAnswersInExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            btnGenerate2.Show();
            numericParam1.Show();
            label2.Show();
            label2.Text="Exam Number: ";
        }

        private void getStudentGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            btnGenerate3.Show();
            numericParam1.Show();
            label2.Show();
            label2.Text="Student ID: ";

        }

        private void getStudentInformationInDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            btnGenerate4.Show();
            numericParam1.Show();
            label2.Show();
            label2.Text="Department ID: ";
        }

        private void getTopicsInCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            btnGenerate5.Show();
            numericParam1.Show();
            label2.Show();
            label2.Text="Course ID: ";
        }


        private void getStudentAnswerInExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            btnGenerate6.Show();
            numericParam1.Show();
            numericParam2.Show();
            label2.Show();
            label1.Show();
            label2.Text="Student ID: ";
        }

        private void btnGenerate1_Click(object sender, EventArgs e)
        {
            int InsId = (int)numericParam1.Value;

            reportViewer1.LocalReport.DataSources.Clear();

            ReportManager.GenerateReport1("GetCrsNameAndStdNumByInsId", InsId, reportViewer1);

            // Refresh the report viewer
            reportViewer1.RefreshReport();

        }


        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            int ExamNo = (int)numericParam1.Value;

            reportViewer1.LocalReport.DataSources.Clear();

            ReportManager.GenerateReport2("getQuestionsAndAnswersByExamNo", ExamNo, reportViewer1);

            // Refresh the report viewer
            reportViewer1.RefreshReport();
        }


        private void btnGenerate3_Click(object sender, EventArgs e)
        {
            int StdId = (int)numericParam1.Value;

            reportViewer1.LocalReport.DataSources.Clear();

            ReportManager.GenerateReport3("getStdGradesById", StdId, reportViewer1);

            // Refresh the report viewer
            reportViewer1.RefreshReport();
        }

        private void btnGenerate4_Click(object sender, EventArgs e)
        {
            int DeptId = (int)numericParam1.Value;

            reportViewer1.LocalReport.DataSources.Clear();

            ReportManager.GenerateReport4("getStudentInformationByDeptId", DeptId, reportViewer1);

            // Refresh the report viewer
            reportViewer1.RefreshReport();

        }
        private void btnGenerate5_Click(object sender, EventArgs e)
        {
            int CrsId = (int)numericParam1.Value;

            reportViewer1.LocalReport.DataSources.Clear();

            ReportManager.GenerateReport5("GetTopicByCourseID", CrsId, reportViewer1);

            // Refresh the report viewer
            reportViewer1.RefreshReport();
        }

        private void btnGenerate6_Click(object sender, EventArgs e)
        {
            int ExamId = (int)numericParam1.Value;
            int StdId = (int)numericParam2.Value;

            reportViewer1.LocalReport.DataSources.Clear();

            ReportManager.GenerateReport6("getQuesAndStdAnsByExamAndStdId", ExamId, StdId, reportViewer1);

            // Refresh the report viewer
            reportViewer1.RefreshReport();
        }


    }
}
