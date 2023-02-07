using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem.ArtForms
{
    public class LiteraryArt : Art
    {
        public int LiteraryArtId { get; set; }
        public readonly new ArtForm Type = ArtForm.Literary;
    }
}
