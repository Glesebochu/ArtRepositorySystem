using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public class FeedbackForm
    {
        public int FeedbackFromId { get; set; }
        public List<QnA> Questions { get; set; }
    }
}
