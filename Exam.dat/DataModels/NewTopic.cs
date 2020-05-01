using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.dat.DataModels
{
   public partial class NewTopic
    {
        public int Id { get; set; }
        public int Topid { get; set; }
        public string TopicSytemId { get; set; }
        public string Title { get; set; }
        public string OptionOne { get; set; }
        public string OptionTow { get; set; }
        public string OptionThree { get; set; }
        public string OptionFour { get; set; }
        public string Kind { get; set; }
        public string Degree { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int MistakeNum { get; set; }

    }
}
