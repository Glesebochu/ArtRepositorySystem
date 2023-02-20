using DrakeUI.Framework;
using Chart.Mvc.SimpleChart;
namespace ArtRepositorySystem
{
    public class Analytic
    {
        public int AnalyticId { get; set; }
        public string Name { get; set; }
        public bool Visibility { get; set; }
        private int numberOflike;
        private int numberOfDislike;
        private int numberOfView;
        private Feedback feedback;

        public Analytic()
        {
            InitializeComponent();
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

