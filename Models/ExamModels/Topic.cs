using System;
using System.Collections.Generic;

namespace Models.ExamModels
{
    public partial class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OptionOne { get; set; }
        public string OptionTow { get; set; }
        public string OptionThree { get; set; }
        public string OptionFour { get; set; }
        public string Answer { get; set; }
        public string Kind { get; set; }
        public string Degree { get; set; }

        //public virtual DegreeTb DegreeNavigation { get; set; }
        //public virtual TopicTypeTb KindNavigation { get; set; }
    }
}
