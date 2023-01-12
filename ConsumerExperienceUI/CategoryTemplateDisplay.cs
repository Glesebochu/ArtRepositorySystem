using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    public partial class CategoryTemplateDisplay : UserControl
    {
        public CategoryTemplateDisplay()
        {
            InitializeComponent();
        }

        public CategoryTemplateDisplay(string categoryName, List<VisualArt> visualArts)
        {
            InitializeComponent();
            LblCategoryName.Text = categoryName;

            this.Controls.Remove(resultsGridCategoryResults);
            resultsGridCategoryResults = new ResultsGrid(visualArts);
            resultsGridCategoryResults.Dock = DockStyle.Fill;
            this.Controls.Add(resultsGridCategoryResults);
            resultsGridCategoryResults.BringToFront();
        }

    }
}
