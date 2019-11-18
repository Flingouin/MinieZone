using System;
using System.Collections.Generic;
using System.Linq;
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
            int nbArticle = commande.ListeArticle.Count;
            double prixTotal = commande.ListeArticle.Where(la => la.PrixHT > 0).Sum(la => la.PrixHT);
                switch (commande.Livraison.Pays.Localisation)
                {
                    case EnumLocalisation.France:
                    if (nbArticle > 3 || prixTotal >= 50)
                        result = 0;
                    else
                        result = 5;
                        break;
                    case EnumLocalisation.Europe:
                        result = 10;
                        if (prixTotal >= 50)
                            result = 0;
                        break;
                    case EnumLocalisation.Autre:
                    if (nbArticle > 5)
                    {
                        result = 20;
                        if (prixTotal >= 100)
                            result = 0;
                    }
                    else
                        result = 20;
                    break;
                    default:
                        break;
            }
            return result;
        }
    }
}
