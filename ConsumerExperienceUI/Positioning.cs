using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem.ConsumerExperienceUI
{
    internal static class Positioning
    {
        public static void CenterHorizontally(this Control c)
        {
            Rectangle parentRect = c.Parent.ClientRectangle;
            c.Left = (parentRect.Width - c.Width) / 2;
        }
        public static void CenterVertically(this Control c)
        {
            Rectangle parentRect = c.Parent.ClientRectangle;
            c.Top = (parentRect.Height - c.Height) / 2;
        }
    }
}
