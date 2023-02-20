using ArtRepositorySystem.ArtForms.VisualArts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem.ArtForms
{
    public class VisualArt : Art
    {
        
        public byte[] Image { get; set; }
        public VisualArtShape VisualArtShape { get; set; }
        public VisualArtType VisualArtType { get; set; }

        public readonly new ArtForm Type = ArtForm.Visual;
        public String Genre { get; set; }

        //From a list of VisualArt objects, select and return those that correspond to 
        //the specified VisualArtType.
        public static List<VisualArt> GetByVisualArtType(List<VisualArt> visuals, VisualArtType type)
        {
            return visuals.FindAll(t => t.VisualArtType == type);
        }
    }
}
