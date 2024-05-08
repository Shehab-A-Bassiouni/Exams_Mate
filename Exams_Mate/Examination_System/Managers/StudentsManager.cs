using Examination_System.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course = Examination_System.Models.Course;

namespace Examination_System.Managers
{
    public static class StudentsManager
    {
        public static List<Course> All_Courses = new();
        public static Models.ITI_Exam_SystemContext ctx = new();
        public static List<Models.Course> crcsNotIn = new();
        public static List<int> crcsIn = new();
        public static List<QuestionsBank> tmp_questions = new();
        public static List<Answer> tmp_answers = new();



        public static List<Course> Get_All_Crs() {
            All_Courses = ctx.Courses.FromSqlRaw("EXEC Get_All_Courses").ToList();
            return All_Courses;
        }

        public static bool join_crs(int crs_id , int stud_id) {
            var parameters = new[] {
                new SqlParameter("@crs_id", crs_id),
                new SqlParameter("@stud_id", stud_id)

            };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC stud_join_crs_by_id  @crs_id , @stud_id ", parameters);
            ctx.SaveChanges();
            return true;
        }

        public static List<Models.Course> Get_Crs_not_in(int stud_id) {
            var parameters = new[] {
                new SqlParameter("@stud_id", stud_id)
            };
            Models.ITI_Exam_SystemContext ctx = new();

            List<Models.Course> instr = ctx.Courses.FromSqlRaw("EXEC get_crsrs_stud_not_in  @stud_id ", parameters).ToList();
            ctx.SaveChanges();

            return instr;
        }

        public static List<Models.StudentCourse> all_stud_crcs() {
            Models.ITI_Exam_SystemContext ctx = new();

            List<Models.StudentCourse> all = ctx.StudentCourses.FromSqlRaw("EXEC get_crcs_stud").ToList();
            ctx.SaveChanges();

            return all;

        }

        public static void load_all_student_crcs() {
            
            var res = StudentsManager.all_stud_crcs();

            foreach (var item in res)
            {
                if (item.StdId == LoginManager.UserTypeID)
                {
                    crcsIn.Add(item.CrsId);
                }
            }

            foreach (var item in StudentsManager.All_Courses)
            {
                if (!crcsIn.Contains(item.CrsId))
                    crcsNotIn.Add(item);
            }

        }
        public static List<Exam> get_Exams(int crs_id) {
            load_all_student_crcs();

            List<Exam> exams = new();
            Models.ITI_Exam_SystemContext ctx = new();

            var parameters = new[] {
               new SqlParameter("@crs_id", crs_id)
                                                                    };
                List<Exam> tmp  = ctx.Exams.FromSqlRaw("EXEC get_all_stud_exams  @crs_id ", parameters).ToList();
                ctx.SaveChanges();

                exams = exams.Union(tmp).ToList();
            

            return exams;
        }

        public static List<int> get_Stud_Crcs()
        {
            Get_All_Crs();
            load_all_student_crcs();

            return crcsIn;
        }

        public static Exam get_exam_data(int exam_no) {
            Models.ITI_Exam_SystemContext ctx = new();

            var parameters = new[] {
               new SqlParameter("@exam_no", exam_no)
                                                                    };
            Exam tmp = ctx.Exams.FromSqlRaw("EXEC get_exam_data  @exam_no ", parameters).ToList()[0];
            ctx.SaveChanges();

            return tmp;
        }

        public static void get_Exam_Questions(int exam_no) {
            Models.ITI_Exam_SystemContext ctx = new();

            var parameters = new[] {
               new SqlParameter("@exam_no", exam_no)
                                                                    };
            tmp_questions = ctx.QuestionsBanks.FromSqlRaw("EXEC get_exam_questions  @exam_no ", parameters).ToList();
            ctx.SaveChanges();

        }

        public static List<Answer> get_answer_for_ques(int ques_id) {
            Models.ITI_Exam_SystemContext ctx = new();

            var parameters = new[] {
               new SqlParameter("@ques_id", ques_id)
                                                                    };


            var x= ctx.Answers.FromSqlRaw("EXEC get_questions_answers_stud  @ques_id ", parameters).ToList();
            ctx.SaveChanges();
            return x;
        }

        public static bool insert_answer_mcq(int ques_id , int stud_id , int exam_id , int? grade , string choice) {

            var parameters = new[] {
                new SqlParameter("@ques_id", ques_id),
                new SqlParameter("@stud_id", stud_id),
                new SqlParameter("@exam_id", exam_id),
                new SqlParameter("@grade", grade),
                new SqlParameter("@choice", choice)

            };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC check_stud_answer_mcq  @ques_id , @stud_id,@exam_id ,@grade ,@choice ", parameters);
            ctx.SaveChanges();
            return true;
        }

        public static bool insert_answer_tf(int ques_id, int stud_id, int exam_id, int? grade, string choice)
        {

            var parameters = new[] {
                new SqlParameter("@ques_id", ques_id),
                new SqlParameter("@stud_id", stud_id),
                new SqlParameter("@exam_id", exam_id),
                new SqlParameter("@grade", grade),
                new SqlParameter("@choice", choice)

            };
            Models.ITI_Exam_SystemContext ctx = new();

            ctx.Database.ExecuteSqlRaw("EXEC check_stud_answer_TF  @ques_id , @stud_id,@exam_id ,@grade ,@choice ", parameters);
            ctx.SaveChanges();
            return true;
        }

        

    }
}
