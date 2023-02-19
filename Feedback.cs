using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public class Feedback
    {
        public List<QnA> Questions = new List<QnA>();
        private FeedbackDb fdb = new FeedbackDb();


        // takes the feedBack data that is associated with the current art from layer1 and sends it to the layer3
        public void saveFeedBack()
        {
            fdb.saveFeedBackToDb(this);
        }

        // Gets the feedBack data that is associated with the current art from db
        public List<QnA> getFeedBack()
        {
            return fdb.getFeedBackFromDb();
        }
    }
}
