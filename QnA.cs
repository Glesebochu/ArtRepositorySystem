using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public enum QuestionType
    {
        YesOrNo,
        SingleSelect,
        MultiSelect,
        ShortAnswer,
        LongAnswer
    }
    public class QnA
    {
        private string _Answer;
        private QuestionType _Type;
        private string _Prompt;

        public int? QnAId { get; set; }
    
        List<Option> OptionsSuppliedByArtist { get; set; }
        List<Reaction>? ConsumersReactions { get; set; }

        public string Prompt
        { 
            get { return _Prompt; } 
            set { _Prompt = value; } 
        }

        public QuestionType Type
        { 
            get { return _Type; } 
            set { _Type = value; } 
        }

        public QnA() { }

        public QnA(string prompt, QuestionType type, List<Option> optionsSuppliedByArtist)
        {
            this.Prompt = prompt;
            this.Type = type;
            this.OptionsSuppliedByArtist = optionsSuppliedByArtist;
        }
        public string Answer
        { 
            get { return _Answer; } 
            set { _Answer = value; } 
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ArtRepositorySystem
//{
//    public enum QuestionType
//    {
//        YesOrNo,
//        SingleSelect,
//        MultiSelect,
//        ShortAnswer,
//        LongAnswer
//    }
//    public class QnA
//    {
//        public int? QnAId { get; set; }
//        string Prompt { get; set; }
//        QuestionType Type { get; set; }
//        List<Option> OptionsSuppliedByArtist { get; set; }
//        List<Reaction>? ConsumersReactions { get; set; }

//        public QnA() { }

//        public QnA(string prompt, QuestionType type, List<Option> optionsSuppliedByArtist)
//        {
//            this.Prompt = prompt;
//            this.Type = type;
//            this.OptionsSuppliedByArtist = optionsSuppliedByArtist;
//        }
//    }
//}
