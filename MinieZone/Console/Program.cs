using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure;

namespace ConsoleDeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Commande commande = new Commande();
            Random random = new Random();
            commande.ListeArticle.Add(new Article { Nom = "Article 1", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 2", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 3", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 4", PrixHT = Math.Round(random.NextDouble() * 40, 2) });

            List<double> ListPrixProduit = commande.ListeArticle.Select(ls => ls.PrixHT).ToList();
            double prixTotalHT = commande.SommeHT(ListPrixProduit);
            double prixTotalTTC = commande.SommeTTC(ListPrixProduit);

            commande.ListeArticle.ForEach(a => Console.WriteLine(a.Detail(a)));
            Console.WriteLine("Prix total HT : " + prixTotalHT);
            Console.WriteLine("Prix total TTC : " + prixTotalTTC);
            Console.WriteLine("Date de création : " + commande.Date);
            Console.ReadKey();
        }
    }
}
