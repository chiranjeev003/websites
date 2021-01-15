using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    public class StudentWithResult
    {
        public int FStudentID { get; set; }
        public string FStudentName { get; set; }
        public int EC1 { get; set; }
        public int EC2 { get; set; }
        public int EC3 { get; set; }
        public int EC4 { get; set; }
        public int EC5 { get; set; }
        public string Result { get; set; }
        public string TotalMarks { get; set; }
    }
}