using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem.DbClasses
{
    internal class FeedbackDb
    {
        // Saves the feedBack data that is associated with the desired art to the dataBase
        public void saveFeedBackToDb(FeedbackForm fb) { }

        // Gets the feedBack data that is associated with the desired art from the dataBase
        public List<QnA> getFeedBackFromDb()
        {
            List<QnA> result = new List<QnA>();

            // First feedBack
            QnA q1 = new QnA() { Type = QuestionType.YesOrNo, Prompt = null, Answer = "No" };
            QnA q2 = new QnA() { Type = QuestionType.YesOrNo, Prompt = null, Answer = "Yes" };
            QnA q3 = new QnA() { Type = QuestionType.YesOrNo, Prompt = null, Answer = "No" };
            QnA q4 = new QnA() { Type = QuestionType.MultiSelect, Prompt = null, Answer = "Maybe" };
            QnA q5 = new QnA() { Type = QuestionType.ShortAnswer, Prompt = null, Answer = "I found the art intresting" };


            // Second FeedBack
            QnA q6 = new QnA() { Type = QuestionType.YesOrNo, Prompt = null, Answer = "No" };
            QnA q7 = new QnA() { Type = QuestionType.YesOrNo, Prompt = null, Answer = "Yes" };
            QnA q8 = new QnA() { Type = QuestionType.YesOrNo, Prompt = null, Answer = "No" };
            QnA q9 = new QnA() { Type = QuestionType.MultiSelect, Prompt = null, Answer = "Maybe" };
            QnA q10 = new QnA() { Type = QuestionType.ShortAnswer, Prompt = null, Answer = "I found the art intresting" };


            // add the QnA objects to the result list
            result.Add(q1);
            result.Add(q2);
            result.Add(q3);
            result.Add(q4);
            result.Add(q5);
            result.Add(q6);
            result.Add(q7);
            result.Add(q8);
            result.Add(q9);
            result.Add(q10);


            // return the result list
            return result;
        }
    }
}
