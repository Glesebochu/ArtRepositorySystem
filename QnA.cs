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
        string Prompt { get; set; }
        QuestionType Type { get; set; }
        string Answer { get; set; }
    }
}
