using ArtRepositorySystem.ArtForms;
using ArtRepositorySystem.DbClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public class FeedbackForm
    {
        public int? FeedbackFromId { get; set; }
        public List<QnA> Questions { get; set; }

        private FeedbackDb fdb = new FeedbackDb();

        public FeedbackForm() { }

        public FeedbackForm(List<QnA> questions) {
            this.Questions = questions;
        }



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

