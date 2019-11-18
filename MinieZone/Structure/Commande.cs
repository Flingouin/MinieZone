using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    public class Commande
    {
        public Guid ID_Commande { get; set; } = Guid.NewGuid();

        public DateTime Date { get; set; } = DateTime.Now;

        public List<Article> ListeArticle { get; set; } = new List<Article>();

        public Facturation Facturation { get; set; }
        public Livraison Livraison { get; set; }

        public double SommeTTC(double SommeHT)
        {
            return (SommeHT * 1.20);
        }

    }
}
