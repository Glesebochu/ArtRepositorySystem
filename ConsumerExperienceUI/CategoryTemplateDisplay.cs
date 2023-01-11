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

            resultsGridArtworks = new ResultsGrid(visualArts);
            resultsGridArtworks.Dock = DockStyle.Fill;
            this.Controls.Add(resultsGridArtworks);
            resultsGridArtworks.BringToFront();
        }

    }
}
