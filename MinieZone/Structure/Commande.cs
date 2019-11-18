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
            return Math.Round(SommeHT * 1.20,2);
        }

        public int PrixLivraison(Commande commande)
        {
            int result = 0;
            if (commande.ListeArticle.Count < 3)
            {
                switch (commande.Livraison.Pays.Localisation)
                {
                    case EnumLocalisation.France:
                        result = 5;
                        break;
                    case EnumLocalisation.Europe:
                        result = 10;
                        break;
                    case EnumLocalisation.Autre:
                        result = 20;
                        break;
                    default:
                        result = 20;
                        break;
                }
            }
            return result;
        }
    }
}
