using System;
using System.Collections.Generic;

namespace Models.ExamModels
{
    public partial class DegreeTb
    {
        public DegreeTb()
        {
            //Topic = new HashSet<Topic>();
        }

        public int Id { get; set; }
        public string Degree { get; set; }

      //  public virtual ICollection<Topic> Topic { get; set; }
    }
}
