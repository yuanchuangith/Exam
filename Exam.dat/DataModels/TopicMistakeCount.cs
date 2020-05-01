using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Exam.dat.DataModels
{
    public class TopicMistakeCount
    {
        [Key] 
        public int ID { get; set; }
        public int Topicid { get; set; }
        public int Count { get; set; }
        public virtual Topic  Topics { get; set; }
    }
}
