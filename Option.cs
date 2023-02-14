using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtRepositorySystem
{
    public class Option
    {
        public int? OptionId { get; set; }
        public string Value { get; set; }

        public Option (string value)
        {
            this.Value = value;
        }   
    }
}
