using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    enum VisualArtShape
    {
        Square,
        Rectangle,
        Circle,
    }
    enum VisualArtType
    {
        Painting,
        Photograph
    }
    internal class VisualArt : Art
    {
        public Image Image { get; set; }
        public VisualArtShape Shape { get; set;}
        public VisualArtType Type { get; set;}
    }
}
