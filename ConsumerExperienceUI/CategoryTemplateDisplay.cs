using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtRepositorySystem.ArtForms;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    public partial class CategoryTemplateDisplay : UserControl
    {
        public CategoryTemplateDisplay(string categoryName, List<VisualArt> visualArts)
        {
            InitializeComponent();
            LblCategoryName.Text = categoryName;

            //List<VisualArt> visualArts = Art.ToVisualArt(arts);

            ResultsGrid resultsGridCategoryResults = new ResultsGrid(visualArts);
            resultsGridCategoryResults.Dock = DockStyle.Fill;
            resultsGridCategoryResults.AutoSize= true;
            this.Controls.Add(resultsGridCategoryResults);
            resultsGridCategoryResults.BringToFront();

        }

    }
}
