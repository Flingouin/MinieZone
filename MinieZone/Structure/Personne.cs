using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    public class Personne
    {
        public Guid ID_Personne { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public List<Facturation> Facturation { get; set; } = new List<Facturation>();

        public List<Livraison> Livraison { get; set; } = new List<Livraison>();
    }
}
