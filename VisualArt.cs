using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public enum VisualArtShape
    {
        Square,
        Rectangle,
        Circle,
    }
    public enum VisualArtType
    {
        Painting,
        Photograph
    }
    public enum PaintingGenre
    {
        Renaissance,
        Rococo,
        Romanticism,
        Expressionism,
        Impressionism,
        Surrealism,
        Abstract,
        Bauhaus,
        Pop,
        Realist
    }
    public enum PhotographGenre
    {
        Portrait,
        Photojournalis,
        Fashion,
        Sports,
        Still,
        Editorial,
        Architectural
    }
    public class VisualArt : Art
    {
        public Image Image { get; set; }
        public VisualArtShape Shape { get; set;}
        public VisualArtType VisualArtType { get; set;}
        public PaintingGenre? PaintingGenre { get; set;}
        public PhotographGenre? PhotographGenre { get; set;}
    }
}
