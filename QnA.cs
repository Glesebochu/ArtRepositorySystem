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
        public int? QnAId { get; set; }
        string Prompt { get; set; }
        QuestionType Type { get; set; }
        List<Option> OptionsSuppliedByArtist { get; set; }
        List<Reaction>? ConsumersReactions { get; set; }

        public QnA (string prompt, QuestionType type, List<Option> optionsSuppliedByArtist)
        {
            this.Prompt = prompt;
            this.Type = type;
            this.OptionsSuppliedByArtist = optionsSuppliedByArtist;
        }
    }
}
