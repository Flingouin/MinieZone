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
            Commande commande = new Commande() { Facturation = new Facturation {
                CodePostal = 68000,
                NomDeRue = "Rue des mésanges",
                NumeroDeRue = 2,
                Pays = "France",
                Ville = "Colmar",
                Personne = new Personne { Nom = "PIERRE", Prenom = "Paul"}
            }, Livraison = new Livraison {
                CodePostal = 68000,
                NomDeRue = "Rue des mésanges",
                NumeroDeRue = 2,
                Pays = "France",
                Ville = "Colmar",
                Personne = new Personne { Nom = "JAQUES", Prenom = "Henry" }
            }
            };
            Random random = new Random();
            commande.ListeArticle.Add(new Article { Nom = "Article 1", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 2", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 3", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 4", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 5", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 6", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 7", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 8", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 9", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 10", PrixHT = Math.Round(random.NextDouble() * 40, 2) });

            double prixTotalHT = commande.ListeArticle.Sum(ls => ls.PrixHT);
            double prixTotalTTC = commande.SommeTTC(prixTotalHT);

            commande.ListeArticle.ForEach(a => Console.WriteLine(a.Detail(a)));
            Console.WriteLine("Prix total HT : " + prixTotalHT);
            Console.WriteLine("Prix total TTC : " + prixTotalTTC);
            Console.WriteLine("Date de création : " + commande.Date);
            Console.WriteLine("___________________");
            Console.WriteLine("Adresse de Facturation : " + commande.Livraison.Detail(commande.Livraison));
            Console.WriteLine("Adresse de livraison : " + commande.Facturation.Detail(commande.Facturation));
            Console.WriteLine("Date de livraison : " + commande.Livraison.DateLivraison.ToShortDateString());
            Console.ReadKey();
        }
    }
}
