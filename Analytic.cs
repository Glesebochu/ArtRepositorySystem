using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    //An Analytic is an insight extracted from the feedback collected on an artwork.
    //eg. "51% of consumers liked this artwork" is one analytic.
    public class Analytic
    {
        public int AnalyticId { get; set; }
        public string Name { get; set; }
        public bool Visibility { get; set; }
    }
}
