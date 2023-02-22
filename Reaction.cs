using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtRepositorySystem.ArtForms;

namespace ArtRepositorySystem
{
    //A class that represents a single reaction made by a single user on a single artwork.
    public class Reaction
    {
        public int ReactionId { get; set; }
        public User Consumer { get; set; }
        public Art Artwork { get; set; }
        public string Response { get; set; }

        public Reaction() { }
        
        
        public Reaction(User consumer, Art artwork, string response)
        {
            Consumer = consumer;
            Artwork = artwork;
            Response = response;
        }

       
    }
}
