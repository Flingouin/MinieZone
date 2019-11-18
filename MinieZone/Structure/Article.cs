using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    public class Article
    {
        public Guid ID_Article { get; set; } = Guid.NewGuid();

        public double PrixHT { get; set; }

        public string Nom { get; set; }

        public string Detail(Article article)
        {
            return "ID Article : " + article.ID_Article + " | Nom : " + article.Nom + " | Prix : " + article.PrixHT;
        }
    }
}
