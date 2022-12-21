using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mededa
{
    enum ReactionType
    {
        Vote,
        Accuracy,
        Feeling,
    }
    internal class Reaction
    {
        public ReactionType Type { get; set; }
    }
}
