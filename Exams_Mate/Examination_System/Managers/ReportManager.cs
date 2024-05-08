using Examination_System.DataSet1TableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Managers
{
    public class ReportManager
    {
        public static void GenerateReport1(string reportName, int parameterValue, ReportViewer reportViewer)
        {

            DataSet1.getCrsNameAndStdNumByInsIdDataTable DS1 = new DataSet1.getCrsNameAndStdNumByInsIdDataTable();
            getCrsNameAndStdNumByInsIdTableAdapter A1 = new getCrsNameAndStdNumByInsIdTableAdapter();
            A1.Fill(DS1, parameterValue);

            var Datatable = DS1.ToList();

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", Datatable);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            // Set processing mode to Local
            reportViewer.ProcessingMode = ProcessingMode.Local;

            // Set the report path
            string reportPath = Path.Combine(Application.StartupPath, "Reports", $"{reportName}.rdlc");
            reportViewer.LocalReport.ReportPath = reportPath;

        }

        public static void GenerateReport2(string reportName, int parameterValue, ReportViewer reportViewer)
        {

            DataSet1.getQuestionsAndAnswersByExamNoDataTable DS1 = new DataSet1.getQuestionsAndAnswersByExamNoDataTable();
            getQuestionsAndAnswersByExamNoTableAdapter A1 = new getQuestionsAndAnswersByExamNoTableAdapter();
            A1.Fill(DS1, parameterValue);

            var Datatable = DS1.ToList();

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", Datatable);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            // Set processing mode to Local
            reportViewer.ProcessingMode = ProcessingMode.Local;

            // Set the report path
            string reportPath = Path.Combine(Application.StartupPath, "Reports", $"{reportName}.rdlc");
            reportViewer.LocalReport.ReportPath = reportPath;

        }

        public static void GenerateReport3(string reportName, int parameterValue, ReportViewer reportViewer)
        {

            DataSet1.getStdGradesByIdDataTable DS1 = new DataSet1.getStdGradesByIdDataTable();
            getStdGradesByIdTableAdapter A1 = new getStdGradesByIdTableAdapter();
            A1.Fill(DS1, parameterValue);

            var Datatable = DS1.ToList();

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", Datatable);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            // Set processing mode to Local
            reportViewer.ProcessingMode = ProcessingMode.Local;

            // Set the report path
            string reportPath = Path.Combine(Application.StartupPath, "Reports", $"{reportName}.rdlc");
            reportViewer.LocalReport.ReportPath = reportPath;

        }

        public static void GenerateReport4(string reportName, int parameterValue, ReportViewer reportViewer)
        {

            DataSet1.getStudentInformationByDeptIdDataTable DS1 = new DataSet1.getStudentInformationByDeptIdDataTable();
            getStudentInformationByDeptIdTableAdapter A1 = new getStudentInformationByDeptIdTableAdapter();
            A1.Fill(DS1, parameterValue);

            var Datatable = DS1.ToList();

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", Datatable);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            // Set processing mode to Local
            reportViewer.ProcessingMode = ProcessingMode.Local;

            // Set the report path
            string reportPath = Path.Combine(Application.StartupPath, "Reports", $"{reportName}.rdlc");
            reportViewer.LocalReport.ReportPath = reportPath;

        }

        public static void GenerateReport5(string reportName, int parameterValue, ReportViewer reportViewer)
        {

            DataSet1.getCoursTopicsByCrsIdDataTable DS1 = new DataSet1.getCoursTopicsByCrsIdDataTable();
            getCoursTopicsByCrsIdTableAdapter A1 = new getCoursTopicsByCrsIdTableAdapter();
            A1.Fill(DS1, parameterValue);

            var Datatable = DS1.ToList();

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", Datatable);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            // Set processing mode to Local
            reportViewer.ProcessingMode = ProcessingMode.Local;

            // Set the report path
            string reportPath = Path.Combine(Application.StartupPath, "Reports", $"{reportName}.rdlc");
            reportViewer.LocalReport.ReportPath = reportPath;

        }

        public static void GenerateReport6(string reportName, int parameterValue1, int parameterValue2, ReportViewer reportViewer)
        {

            DataSet1.getQuesAndStdAnsByExamAndStdIdDataTable DS1 = new DataSet1.getQuesAndStdAnsByExamAndStdIdDataTable();
            getQuesAndStdAnsByExamAndStdIdTableAdapter A1 = new getQuesAndStdAnsByExamAndStdIdTableAdapter();
            A1.Fill(DS1, parameterValue1, parameterValue2);

            var Datatable = DS1.ToList();

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", Datatable);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            // Set processing mode to Local
            reportViewer.ProcessingMode = ProcessingMode.Local;

            // Set the report path
            string reportPath = Path.Combine(Application.StartupPath, "Reports", $"{reportName}.rdlc");
            reportViewer.LocalReport.ReportPath = reportPath;

        }
    }
}
