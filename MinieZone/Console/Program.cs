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
            List<Pays> ListePays = new List<Pays>();
            ListePays.Add(new Pays { Localisation = EnumLocalisation.France, Nom = "France" });
            ListePays.Add(new Pays { Localisation = EnumLocalisation.Europe, Nom = "Italie" });
            ListePays.Add(new Pays { Localisation = EnumLocalisation.Autre, Nom = "USA" });
            Commande commande = new Commande() { Facturation = new Facturation {
                CodePostal = 68000,
                NomDeRue = "Rue des mésanges",
                NumeroDeRue = 2,
                Pays = ListePays.FirstOrDefault(p => p.Nom=="France"),
                Ville = "Colmar",
                Personne = new Personne { Nom = "PIERRE", Prenom = "Paul"}
            }, Livraison = new Livraison {
                CodePostal = 68000,
                NomDeRue = "Rue des mésanges",
                NumeroDeRue = 2,
                Pays = ListePays.FirstOrDefault(p => p.Nom == "USA"),
                Ville = "Colmar",
                Personne = new Personne { Nom = "JAQUES", Prenom = "Henry" }
            }
            };
            Random random = new Random();
            commande.ListeArticle.Add(new Article { Nom = "Article 1", PrixHT = -1 });
            commande.ListeArticle.Add(new Article { Nom = "Article 2", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 3", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 4", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 5", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 6", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 7", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 8", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 9", PrixHT = Math.Round(random.NextDouble() * 40, 2) });
            commande.ListeArticle.Add(new Article { Nom = "Article 10", PrixHT = Math.Round(random.NextDouble() * 40, 2) });

            double prixTotalHT = commande.ListeArticle.Where(ls => ls.PrixHT>=0).Sum(ls => ls.PrixHT);
            double prixMoyen = Math.Round(commande.ListeArticle.Select(ls => ls.PrixHT).Average(),2);
            double prixTotalTTC = commande.SommeTTC(prixTotalHT);
            int livraison = commande.PrixLivraison(commande);
            prixTotalTTC += livraison;

            if (prixTotalHT < 0)
            {
                Console.WriteLine("Montant impossible négatif");
                Console.ReadKey();
            }
            else
            {
                commande.ListeArticle.ForEach(a => Console.WriteLine(a.Detail(a)));
                Console.WriteLine("___________________");
                Console.WriteLine("Prix total HT : " + prixTotalHT);
                Console.WriteLine("Prix total TTC : " + prixTotalTTC);
                Console.WriteLine("Dont livraison : " + livraison);
                Console.WriteLine("Prix moyen d'un article : " + prixMoyen);
                Console.WriteLine("Date de création : " + commande.Date);
                Console.WriteLine("___________________");
                Console.WriteLine("Adresse de Facturation : " + commande.Livraison.Detail(commande.Livraison));
                Console.WriteLine("Adresse de livraison : " + commande.Facturation.Detail(commande.Facturation));
                Console.WriteLine("Date de livraison estimé : " + commande.Livraison.DateLivraison.ToShortDateString());
                Console.ReadKey();
            }
        }
    }
}
