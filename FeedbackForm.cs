using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public class FeedbackForm
    {
        [Key]
        public int? FeedbackFromId { get; set; }
        public List<QnA> Questions { get; set; }

        public FeedbackForm(List<QnA> questions) { 
            this.Questions = questions;
        }
    }
}
