using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    enum PaintingShape
    {
        Square,
        Rectangle,
        Circle
    }
    internal class Painting : Art
    {
        public Image? Image { get; set; }
        public PaintingShape Shape { get; set; }

    }
}
