using System;
using System.Collections.Generic;

namespace Models.ExamModels
{ 
    public partial class User
    {
        public User()
        {
            //Mistake = new HashSet<Mistake>();
            //Studentscore = new HashSet<Studentscore>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string ImgUrl { get; set; }
        public string Class { get; set; }
        public string Kind { get; set; }

        //public virtual ICollection<Mistake> Mistake { get; set; }
        //public virtual ICollection<Studentscore> Studentscore { get; set; }
    }
}
