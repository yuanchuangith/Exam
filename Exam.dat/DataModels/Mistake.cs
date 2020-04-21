using System;
using System.Collections.Generic;

namespace Exam.dat.DataModels
{
    public partial class Mistake
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Calss { get; set; }
        public string Mistake1 { get; set; }
        public string Misanswer { get; set; }
        public string Answer { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
