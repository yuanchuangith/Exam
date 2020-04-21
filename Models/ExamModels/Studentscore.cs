using System;
using System.Collections.Generic;

namespace Models.ExamModels
{
    public partial class Studentscore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Num { get; set; }
        public int? Score { get; set; }

       // public virtual User NameNavigation { get; set; }
    }
}
