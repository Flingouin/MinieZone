using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    public class Livraison : Adresse
    {
        public Guid ID_Livraison { get; set; }
        public DateTime DateLivraison { get; set; } = DateTime.Now.AddDays(7);
    }
}
