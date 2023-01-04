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
    internal class VisualArt : Art
    {
        public Image Image { get; set; }
        public VisualArtShape Shape { get; set;}
        public VisualArtType Type { get; set;}
        public PaintingGenre? PaintingGenre { get; set;}
        public PhotographGenre? PhotographGenre { get; set;}
    }
}
