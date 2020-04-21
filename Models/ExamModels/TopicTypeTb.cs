using System;
using System.Collections.Generic;

namespace Models.ExamModels
{ 
    public partial class TopicTypeTb
    {
        public TopicTypeTb()
        {
           // Topic = new HashSet<Topic>();
        }

        public int Id { get; set; }
        public string TopicType { get; set; }

       // public virtual ICollection<Topic> Topic { get; set; }
    }
}
