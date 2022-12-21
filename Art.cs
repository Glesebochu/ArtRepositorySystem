using ArtRepositorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    internal abstract class Art
    {
        public string Description { get; set; }
        public List<User> Artists { get; set; }
        public List<Analytic> Analytics { get; set; }
    }
}
