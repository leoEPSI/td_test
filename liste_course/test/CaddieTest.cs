using liste_course.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.test
{
    internal class CaddieTest
    {
        public Caddie caddie;
        public CaddieTest() { }

        public bool TestCaddie()
        {
            Console.WriteLine("Test d'un caddie de course=======================");
            
            TestAjouterCourse();
            TestSupprimerProduit();
            TestAfficherCaddie();
            
            Console.WriteLine("Test d'un caddie de course : OK");
            Console.WriteLine();
            return true;
        }

        public bool TestAjouterCourse()
        {
            Produit produit = new Produit(01, "Bananes", 1);
            Caddie caddie = new Caddie();

            // Act
            bool result = Caddie.AjouterCourse(2, produit);

            // Test
            if (result != true)
            {
                Console.WriteLine("L'ajout de course a échoué.");
                return false;
            }
            else
            {
                Console.WriteLine("     ajout de course OK");
            }

            if (Caddie.GetNombreProduits() != 1)
            {
                Console.WriteLine("Le nombre de produits dans la liste est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans la liste OK");
            }

            if (Caddie.GetQuantiteProduit(produit) != 2)
            {
                Console.WriteLine("La quantité de produit dans la liste est incorrecte.");
                return false;
            }
            else
            {
                Console.WriteLine("     quantité de produit dans la liste OK");
            }


            // plus verif de la suppression
            return true;
        }

        public bool TestSupprimerProduit()
        {

            Produit produit1 = new Produit(01, "Café", 3);
            Produit produit2 = new Produit(02, "Lait", 1);
            Caddie caddie = new Caddie();
            caddie.AjouterCourse(2, produit1);
            caddie.AjouterCourse(1, produit2);

            // Act
            bool result = caddie.SupprimerProduit(produit1);

            // Test
            if (result != true)
            {
                Console.WriteLine("La suppression de produit a échoué.");
                return false;
            }
            else
            {
                Console.WriteLine("     suppression de produit OK");
            }

            if (caddie.GetNombreProduits() != 1)
            {
                Console.WriteLine("Le nombre de produits dans la liste est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans la liste OK");
            }

            if (caddie.GetListeProduits()[0] != produit2)
            {
                Console.WriteLine("Le produit restant dans la liste est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     produit restant dans la liste OK");
            }

            return true;
        }

        public bool TestAfficherCaddie()
        {
            Produit produit1 = new Produit(01, "Tomates", 1);
            Produit produit2 = new Produit(02, "Fromage", 4);
            Caddie caddie = new Caddie();
            caddie.AjouterCourse(3, produit1);
            caddie.AjouterCourse(1, produit2);

            // Act
            Console.WriteLine("Liste des produits :");
            caddie.AfficherListeProduit();

            return true;
        }
    }
}
