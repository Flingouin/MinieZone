using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    public class Pays
    {
        public Guid ID_Pays { get; set; } = Guid.NewGuid();
        public string Nom { get; set; }
        public EnumLocalisation Localisation { get; set; }
    }
}
