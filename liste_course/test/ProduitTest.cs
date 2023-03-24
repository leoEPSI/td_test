using liste_course.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.test
{
    internal class ProduitTest
    {
        public Produit produit;

        public ProduitTest()
        {
        }

        public bool creerProduit()
        {
            Console.WriteLine("Test d'un produit =======================");
            produit = new Produit(01, "petit poids", 10);

            if (produit.getId() != 01) { Console.WriteLine("l'id du produit ne correspond pas"); return false; }
            else Console.WriteLine("        L'id du produit est OK");
            
            if (produit.getNom() != "petit poids") { Console.WriteLine("le nom du produit ne correspond pas"); return false; }
            else Console.WriteLine("        le nom du produit est OK");
            
            if (produit.getPrix() != 10) { Console.WriteLine("le prix du produit ne correspond pas"); return false; }
            else Console.WriteLine("        le prix du produit est OK");

            Console.WriteLine("Création de Produit : OK");
            Console.WriteLine();

            return true;
        }
    }
}
