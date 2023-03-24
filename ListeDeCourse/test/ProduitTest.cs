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

        public void creerProduit()
        {
            produit = new Produit(01, "petit poids", 10);

            if (produit.id != 01) { Console.WriteLine("l'id du produit ne correspond pas"); return;  }
            if (produit.nom != "petit poids") { Console.WriteLine("le nom du produit ne correspond pas"); return;  }
            if (produit.prix != 10) { Console.WriteLine("le prix du produit ne correspond pas"); return; }
            //test(produit.prix != 10)
        }

    }
}
