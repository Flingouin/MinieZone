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

        public double SommeHT(List<double> ListePrixHTArticle)
        {
            double result = 0;
            ListePrixHTArticle.ForEach(a => result += a);
            return result;
        }

        public double SommeTTC(List<double> ListePrixHTArticle)
        {
            double result = 0;
            result = SommeHT(ListePrixHTArticle) * 1.20;
            return result;
        }

    }
}
