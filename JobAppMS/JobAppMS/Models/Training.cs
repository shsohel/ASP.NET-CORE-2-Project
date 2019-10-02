using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppMS.Models
{
    public class Training
    {

        [Key]
        public int TrainingID { get; set; }
        public string UserName { get; set; }

        public string TrainingTitle { get; set; }
        public string TopicsCovered { get; set; }
        public int TrainingYear { get; set; }
        public string Institute { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }



    }
}
