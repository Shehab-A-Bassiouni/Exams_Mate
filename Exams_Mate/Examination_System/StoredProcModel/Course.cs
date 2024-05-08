﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System.StoredProcModel;

public partial class Course
{
    public int CrsId { get; set; }

    public string CrsName { get; set; }

    public string State { get; set; }

    public string Description { get; set; }

    public byte? Hours { get; set; }

    public int? TotalGrade { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<QuestionsBank> QuestionsBanks { get; set; } = new List<QuestionsBank>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();

    public virtual ICollection<Department> Depts { get; set; } = new List<Department>();

    public virtual ICollection<Instructor> Ins { get; set; } = new List<Instructor>();
}