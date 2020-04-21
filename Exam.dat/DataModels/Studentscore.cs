using System;
using System.Collections.Generic;

namespace Exam.dat.DataModels
{
    public partial class Studentscore
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public DateTime ExamTime { get; set; }
        public int? Score { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
