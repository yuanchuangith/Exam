using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Exam.dat.DataModels
{
    public partial class NewTeacherTopic
    {
        [Key]
        public int ID { get; set; }
        public string UserId { get; set; }
        public string Class { get; set; }
        public string Scipt { get; set; }
        public DateTime DateTime { get; set; }
        public string TopicSytemId { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
