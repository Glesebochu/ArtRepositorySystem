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
        string _Prompt { get; set; }
        QuestionType _Type { get; set; }
        string _Answer { get; set; }

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

        public QnA (string prompt, QuestionType type, List<Option> optionsSuppliedByArtist)
        {
            this.Prompt = prompt;
            this.Type = type;
            this.OptionsSuppliedByArtist = optionsSuppliedByArtist;
        public string Answer
        { 
            get { return _Answer; } 
            set { _Answer = value; } 
        }
    }
}
