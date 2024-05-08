using Examination_System.Models;
using Examination_System.StoredProcModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Course = Examination_System.Models.Course;
using Department = Examination_System.Models.Department;

namespace Examination_System.Managers
{
	public static class InstructorsManager
	{

		public static List<Course> Instructor_Courses = new();

		public static List<Examination_System.Models.Exam> Instructor_Exams = new();

		public static List<Department> Depts = new();
		public static List<Examination_System.Models.Instructor> All_Instructors = new();

        public static List<Examination_System.Models.QuestionsBank> Temp_Ques_For_Crs_Id = new();
        public static List<Examination_System.Models.Answer> Temp_Answer_For_Ques_Id = new();


        public static List<Course> Get_Instructor_Courses()
		{
            Models.ITI_Exam_SystemContext ctx = new();

            var parameters = new[] {new SqlParameter("@InstID", LoginManager.UserTypeID)};
			Instructor_Courses = ctx.Courses.FromSqlRaw("EXEC Get_Inst_Courses_By_ID @InstID", parameters).ToList();
            ctx.SaveChanges();
            return Instructor_Courses;
		}

        public static List<Examination_System.Models.Instructor> Get_All_Instructor()
        {

         Models.ITI_Exam_SystemContext ctx = new();
        All_Instructors = ctx.Instructors.FromSqlRaw("EXEC Get_All_Instructors").ToList();
            ctx.SaveChanges();

            return All_Instructors;
        }

        public static bool Add_Instructor_Exam(int Duration , int Grade , int crsId , int MCQQues , int TFQues)
		{
			var parameters = new[]
			 {

					new SqlParameter("@Duration", Duration),
					new SqlParameter("@GenerationDate", DateTime.Now),
					new SqlParameter("@PassingGrade", Grade),
					new SqlParameter("@State", "active"),
					new SqlParameter("@InstID", LoginManager.UserTypeID),
					new SqlParameter("@CrsID", crsId),
					new SqlParameter("@McqNUM", MCQQues),
					new SqlParameter("@TfNum", TFQues)
				};
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC GenerateExam  @Duration, @GenerationDate, @State, @PassingGrade , @InstID , @CrsID , @McqNUM ,@TfNum", parameters);
			ctx.SaveChanges();
			return true;
		}

		public static bool Add_Ques_TF(int crs_id , string content , int points , int correct_answ) {
			var parameters = new[]
			 {
					new SqlParameter("@crs_id", crs_id),
					new SqlParameter("@content",content),
					new SqlParameter("@points", points),
					new SqlParameter("@correct_answ", correct_answ)
				};
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Insert_Question_TF  @crs_id, @content, @points, @correct_answ", parameters);
			ctx.SaveChanges();
			return true;
		}

		public static bool Add_Ques_MCQ(int crs_id, string content, int points, int correct_answ ,List<string> options )
		{
			var parameters = new[]
			 {
					new SqlParameter("@crs_id", crs_id),
					new SqlParameter("@content",content),
					new SqlParameter("@points", points),
					new SqlParameter("@option1", options[0]),
					new SqlParameter("@option2", options[1]),
					new SqlParameter("@option3", options[2]),
					new SqlParameter("@option4", options[3]),
					new SqlParameter("@correct_answ", correct_answ)
				};
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Insert_Question_MCQ  @crs_id, @content, @points,@option1,@option2,@option3,@option4, @correct_answ", parameters);
			ctx.SaveChanges();
			return true;
		}

		public static bool Add_Crs(string crs_Name, string state, string descrip, int hours, int totalGrade , int dept_id , int inst_id)
		{


            var parameters = new[]
             {
                    new SqlParameter("@crs_name", crs_Name),
                    new SqlParameter("@state",state),
                    new SqlParameter("@description", descrip),
                    new SqlParameter("@hours", hours),
                    new SqlParameter("@total_grade", totalGrade),
                    new SqlParameter("@department_id", dept_id),
                    new SqlParameter("@instructor_id", inst_id),
                   
                };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Add_Course_All  @crs_name, @state, @description,@hours,@total_grade,@department_id,@instructor_id", parameters);
            ctx.SaveChanges();
            return true;
        }

        public static List<Department> Get_All_Depts()
        {
            Models.ITI_Exam_SystemContext ctx = new();

            Depts = ctx.Departments.FromSqlRaw("EXEC Get_All_Depts").ToList();
            ctx.SaveChanges();

            return Depts;
        }

		public static bool Edit_Course(int crs_id , string crs_name , string state , string descrip , int hours , int total_grade) {

            var parameters = new[] {
                    new SqlParameter("@crsID", crs_id),
                    new SqlParameter("@crsName", crs_name),
                    new SqlParameter("@state",state),
                    new SqlParameter("@desc", descrip),
                    new SqlParameter("@hrs", hours),
                    new SqlParameter("@total_grade", total_grade),
                };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Edit_Courses  @crsID, @crsName, @state,@desc,@hrs,@total_grade", parameters);
            ctx.SaveChanges();
            return true;
        }

		public static bool Edit_Exam(int exam_no , int duration , string state , int passing_grade) {
            var parameters = new[] {
                    new SqlParameter("@exam_no", exam_no),
                    new SqlParameter("@duration", duration),
                    new SqlParameter("@state",state),
                    new SqlParameter("@passing_grade", passing_grade)
                };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC EditExam  @exam_no, @duration, @state,@passing_grade", parameters);
            ctx.SaveChanges();
            return true;

        }

		public static List<Examination_System.Models.Exam> Get_Instructor_Exams(int ins_id) {
            Models.ITI_Exam_SystemContext ctx = new();

            var parameters = new[] { new SqlParameter("@InstID", ins_id) };
            Instructor_Exams = ctx.Exams.FromSqlRaw("EXEC Get_instructor_Exams @InstID", parameters).ToList();
            ctx.SaveChanges();

            return Instructor_Exams;
        }


        public static bool delete_exam(int exam_id) {
            var parameters = new[] {new SqlParameter("@Exam_id", exam_id)};
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Delete_Exam  @Exam_id", parameters);
            ctx.SaveChanges();
            return true;

        }

        public static bool delete_course(int course_id)
        {
            var parameters = new[] { new SqlParameter("@course_id", course_id) };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Delete_Course  @course_id", parameters);
            ctx.SaveChanges();
            return true;

        }

        // not yet
        public static bool edit_dept(int dept_id , string dept_name , string description , int mgr_id)
        {
            var parameters = new[] { 
                new SqlParameter("@dept_id", dept_id),
                new SqlParameter("@dept_name", dept_name),
                new SqlParameter("@description", description),
                new SqlParameter("@mgr_id", mgr_id)
            };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Edit_Dept  @dept_id,@dept_name,@description,@mgr_id", parameters);
            ctx.SaveChanges();
            return true;

        }

        // not yet
        public static bool delete_dept(int dept_id)
        {
            var parameters = new[] {
                new SqlParameter("@dept_id", dept_id)
               
            };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Delete_Dept  @dept_id", parameters);
            ctx.SaveChanges();
            return true;

        }

        public static List<Models.QuestionsBank> get_questions_by_crs(int? crs_id) {

            var parameters = new[] { new SqlParameter("@crs_id", crs_id) };
         Models.ITI_Exam_SystemContext ctx = new();

            Temp_Ques_For_Crs_Id = ctx.QuestionsBanks.FromSqlRaw("EXEC Get_Questions_By_Crs_ID @crs_id", parameters).ToList();
            ctx.SaveChanges();
            return Temp_Ques_For_Crs_Id;

        }

        public static Models.QuestionsBank? get_question_data_by_id(int ques_id , int? crs_id) {
            get_questions_by_crs(crs_id);
            return InstructorsManager.Temp_Ques_For_Crs_Id.FirstOrDefault(item => item.QuestionId == ques_id);
        }

        public static List<Models.Answer>? get_answers_by_ques_id(int ques_id) {
            var parameters = new[] { new SqlParameter("@ques_id", ques_id) };
         Models.ITI_Exam_SystemContext ctx = new();

            Temp_Answer_For_Ques_Id = ctx.Answers.FromSqlRaw("EXEC Get_Answers_By_Ques_ID @ques_id", parameters).ToList();
            ctx.SaveChanges();

            return Temp_Answer_For_Ques_Id;
        }

        public static bool edit_mcq_ques(int QuesId, string QuesContent , int QuesPoints , List<string>answ , int isCorrect)
        {
            var parameters = new[] {
                new SqlParameter("@QuesId", QuesId),
                new SqlParameter("@QuesContent", QuesContent),
                new SqlParameter("@QuesPoints", QuesPoints),
                new SqlParameter("@option1", answ[0]),
                new SqlParameter("@option2", answ[1]),
                new SqlParameter("@option3", answ[2]),
                new SqlParameter("@option4", answ[3]),
                new SqlParameter("@isCorrect", isCorrect)
            };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC Edit_Question_MCQ  @QuesId , @QuesContent , @QuesPoints ,@option1 ,@option2 ,@option3 ,@option4 ,@isCorrect", parameters);
            ctx.SaveChanges();
            return true;
        }

        public static bool edit_tf_ques(int QuesId, string QuesContent, int QuesPoints, List<string> answ, int isCorrect)
        {
            var parameters = new[] {
                new SqlParameter("@QuesId", QuesId),
                new SqlParameter("@QuesContent", QuesContent),
                new SqlParameter("@QuesPoints", QuesPoints),
                new SqlParameter("@option1", answ[0]),
                new SqlParameter("@option2", answ[1]),
                new SqlParameter("@isCorrect", isCorrect)
            };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC edit_ques_tf  @QuesId , @QuesContent , @QuesPoints ,@option1 ,@option2 ,@isCorrect", parameters);
            ctx.SaveChanges();
            return true;
        }

        public static bool refresh_data() {
            Get_Instructor_Courses();
            Get_All_Instructor();
            Get_Instructor_Exams(LoginManager.UserTypeID);
            Get_All_Depts();
            return true;
        }

        public static bool delete_ques_by_id(int ques_id) {
            var parameters = new[] {
                new SqlParameter("@QuesId", ques_id)
            };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC delete_ques  @QuesId ", parameters);
            ctx.SaveChanges();
            return true;
        }

        public static string get_instructors_by_crs_id(int crs_id) {
            var parameters = new[] {
                new SqlParameter("@crs_id", crs_id)
            };
            Models.ITI_Exam_SystemContext ctx = new();

            List<Models.Instructor> instr = ctx.Instructors.FromSqlRaw("EXEC get_instructor_by_crs_id  @crs_id ", parameters).ToList();
            ctx.SaveChanges();
            return instr[0].Fname+" "+instr[0].Lname;
        }

        public static bool add_dept(string dept_name , int mgr_id , string description) {

            var parameters = new[] {
                new SqlParameter("@dept_name", dept_name),
                new SqlParameter("@mgr_id", mgr_id),
                new SqlParameter("@description", description)
            };

            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC AddDepartment  @dept_name ,@description, @mgr_id  ", parameters);
            ctx.SaveChanges();
            return true;
        }
        
    }

}

