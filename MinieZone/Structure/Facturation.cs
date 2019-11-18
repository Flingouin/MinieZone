using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    public class Facturation : Adresse
    {
        public Guid ID_Facturation { get; set; } = Guid.NewGuid();
    }
}
