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
            if (article.PrixHT < 0)
                return string.Format("ID Article : {0} | Article erroné", article.ID_Article);
            else
                return string.Format("ID Article : {0} | Nom : {1} | Prix : {2}", article.ID_Article, article.Nom, article.PrixHT);
        }
    }
}
