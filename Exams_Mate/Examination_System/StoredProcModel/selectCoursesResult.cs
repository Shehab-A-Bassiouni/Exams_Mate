﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_System.StoredProcModel
{
    public partial class selectCoursesResult
    {
        public int crs_id { get; set; }
        public string crs_name { get; set; }
        public string state { get; set; }
        public string description { get; set; }
        public byte? hours { get; set; }
        public int? total_grade { get; set; }
    }
}
