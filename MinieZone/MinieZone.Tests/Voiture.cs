using System;
using System.Collections.Generic;
using System.Text;

namespace MinieZone.Tests
{
    public class Voiture
    {
        public string Couleur { get; set; }

        public void Peindre(string color)
        {
            Couleur = color;
        }

        public string Peindre2(string couleur)
        {
            Couleur = couleur;
            return Couleur;
        }
    }
}
