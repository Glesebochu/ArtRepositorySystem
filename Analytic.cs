using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public class Analytic
    {
        public int AnalyticId { get; set; }
        public string Name { get; set; }
        public bool Visibility { get; set; }
        
        private int numberOflike { get; set; }
        private int numberOfDislike { get; set; }
        private int numberOfView { get; set; }
        private FeedbackForm feedbackForm { get; set; }

    }

}