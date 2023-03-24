using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal class ProduitTest
    {
        public Produit produit;

        public ProduitTest()
        {
        }

        public bool creerProduit()
        {
            produit = new Produit(01, "petit poids", 10);

            if (produit.getId() != 01) { Console.WriteLine("l'id du produit ne correspond pas"); return false;  }
            if (produit.getNom() != "petit poids") { Console.WriteLine("le nom du produit ne correspond pas"); return false;  }
            if (produit.getPrix() != 10) { Console.WriteLine("le prix du produit ne correspond pas"); return false; }

            Console.WriteLine("Création de Produit : OK");

            return true;
        }

    }
}
