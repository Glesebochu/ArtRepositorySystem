using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem.ArtForms
{
    public abstract class Art
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<User> Artists { get; set; }
        //Making this property nullable because an analytic is not
        //available until after the Art has been created.
        public List<Analytic>? Analytics { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DateTime PostedOn { get; set; }
        public ArtForm Type { get; set; }
        public FeedBackForm FeedbackForm { get; set; }

        //Take in a list of Art objects and return only 
        //the objects that are of type VisualArt.
        public static List<VisualArt> ToVisualArt(List<Art> arts)
        {
            List<VisualArt> visualArts = new List<VisualArt>();
            foreach (Art art in arts)
            {
                if (art.Type == ArtForm.Visual)
                {
                    visualArts.Add(art as VisualArt);
                }
            }
            return visualArts;
        }
        //Take in a list of Art objects and return only 
        //the objects that are of type LiteraryArt.
        public static List<LiteraryArt> ToLiteraryArt(List<Art> arts)
        {
            List<LiteraryArt> literaryArts = new List<LiteraryArt>();
            foreach (Art art in arts)
            {
                if (art.Type == ArtForm.Literary)
                {
                    literaryArts.Add(art as LiteraryArt);
                }
            }
            return literaryArts;
        }
        //Take in a list of Art objects and return only 
        //the objects that are of type PerformedArt.
        public static List<PerformedArt> ToPerformedArt(List<Art> arts)
        {
            List<PerformedArt> performedArts = new List<PerformedArt>();
            foreach (Art art in arts)
            {
                if (art.Type == ArtForm.Performed)
                {
                    performedArts.Add(art as PerformedArt);
                }
            }
            return performedArts;
        }
    }
}
