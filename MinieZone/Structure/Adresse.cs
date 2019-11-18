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

        public string Detail(EnumSexe enumSexe, Adresse adresse)
        {
            return string.Format("{0} {1} {2} | {3} {4} {5} {6} {7}", EnumHelper.EnumSexeConverter(enumSexe), adresse.Personne.Nom, adresse.Personne.Prenom, adresse.NumeroDeRue, adresse.NomDeRue, adresse.CodePostal, adresse.Ville, adresse.Pays.Nom);
        }
    }
}
