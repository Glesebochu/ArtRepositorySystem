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
using ArtRepositorySystem.ArtForms.VisualArts;

namespace ArtRepositorySystem.ConsumerExperienceUI
{

    public partial class MyFeedPage : UserControl
    {
        List<Art>? arts;
        //public MyFeedPage()
        //{
        //    InitializeComponent();
        //}
        public MyFeedPage(List<Art> arts)
        {
            InitializeComponent();
            this.arts = arts;
        }

        private void MyFeedPage_Load(object sender, EventArgs e)
        {
            //This will be replaced by a database fetch for the arts that are specific to the user
            arts = ConsumerExperience.GetDummyArts();

            List<VisualArt> visuals = Art.ToVisualArt(arts);

            //Group visual arts by type
            List<VisualArt> paintings = VisualArt.GetByVisualArtType(visuals, VisualArtType.Painting);
            List<VisualArt> photographs = VisualArt.GetByVisualArtType(visuals, VisualArtType.Photograph);

            //Group paintings based on their genre (category)
            List<VisualArt> expressionismVisuals = paintings.FindAll(ex => ex.Genre.Equals(PaintingGenre.Expressionism));
            List<VisualArt> abstractVisuals = paintings.FindAll(ab => ab.Genre.Equals(PaintingGenre.Abstract));
            List<VisualArt> surrealVisuals = paintings.FindAll(sur => sur.Genre.Equals(PaintingGenre.Surrealism));
            
            //Group photographs based on their genre (category)
            List<VisualArt> stillVisuals = photographs.FindAll(still => still.Genre.Equals(PhotographGenre.Still));


            CategoryTemplateDisplay categoryTemplateDisplay1 = new CategoryTemplateDisplay(PaintingGenre.Expressionism.ToString(), expressionismVisuals);
            ConsumerExperience.AddToPanel(categoryTemplateDisplay1, tableLayoutPanelAllArtworks);

            CategoryTemplateDisplay categoryTemplateDisplay2 = new CategoryTemplateDisplay(PaintingGenre.Abstract.ToString(), abstractVisuals);
            ConsumerExperience.AddToPanel(categoryTemplateDisplay2, tableLayoutPanelAllArtworks);

            CategoryTemplateDisplay categoryTemplateDisplay3 = new CategoryTemplateDisplay(PaintingGenre.Surrealism.ToString(), surrealVisuals);
            ConsumerExperience.AddToPanel(categoryTemplateDisplay3, tableLayoutPanelAllArtworks);

            CategoryTemplateDisplay categoryTemplateDisplay4 = new CategoryTemplateDisplay(PhotographGenre.Still.ToString(), stillVisuals);
            ConsumerExperience.AddToPanel(categoryTemplateDisplay4, tableLayoutPanelAllArtworks);
        }

        

    }
}
