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
        private Feedback feedback { get; set; }

    }

}
        private List<Dictionary<String,object>> getQuestionRatio()
        {
            return new List<Dictionary<string, object>> { new Dictionary<string, object> { } };
        }


        public void plotPieChart()
        {
            
        // plots a pieChart
            
        }


        public void plotBarChart()
        {
               // plots a barChart
        }

    }
}

