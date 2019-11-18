using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    public class Adresse
    {
        public int NumeroDeRue { get; set; }
        public string NomDeRue { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public Pays Pays { get; set; }
        public Personne Personne { get; set; }

        public string Detail(Adresse adresse)
        {
            return adresse.Personne.Nom + " " + adresse.Personne.Prenom + " | " + adresse.NumeroDeRue + " " + adresse.NomDeRue + " " + adresse.CodePostal + " " + adresse.Ville + " " + adresse.Pays.Nom;
        }
    }
}
