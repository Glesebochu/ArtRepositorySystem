using ArtRepositorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    internal abstract class Art
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<User> Artists { get; set; }
        //Making this property nullable because an analytic is not
        //available until after the Art has been created.
        public List<Analytic>? Analytics { get; set; }

        public Art() { }
        public Art(string title, string description, List<User> artists)
        {
            Title = title;
            Description= description;
            Artists = artists;
        }
    }
}
