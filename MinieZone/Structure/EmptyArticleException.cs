using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Structure
{
    public class EmptyArticleException : Exception
    {
        public void Exception(List<Article> ListeArticleCalculable, List<Article>ListeToutArticle)
        {
            string erreur;
            if (ListeArticleCalculable.Count == 0 && ListeToutArticle.Count > 0)
                erreur = "Les articles calculables ont une valeur négative";
            else
                erreur = "Aucun article n'a été sélectionné";
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Log(erreur, w);
            }
        }
        public void Log(string logMessage, TextWriter w)
        {
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }
    }
}
