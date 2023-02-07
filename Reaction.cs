using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public enum ReactionType
    {
        Vote,
        Accuracy,
        Feeling,
    }
    public class Reaction
    {
        public int ReactionId { get; set; }
        public ReactionType Type { get; set; }
    }
}
