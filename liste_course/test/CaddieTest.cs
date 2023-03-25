using liste_course.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.test
{
    using liste_course.model;
    internal class CaddieTest
    {
        public CaddieTest() { }

        public bool TestCaddie()
        {
            Console.WriteLine("Test d'un caddie de course=======================");
            
            if(! TestAjouterCourse()) return false;
            if(! TestSupprimerProduit()) return false;
            
            Console.WriteLine("Test d'un caddie de course : OK");
            return true;
        }

        public bool TestAjouterCourse()
        {
            Produit produit = new Produit(01, "Bananes", 1);
            ListeCourse listeCours = new ListeCourse("course add");
            listeCours.AjouterCourse(new Course(2, produit));
            Caddie caddie = new Caddie(listeCours);

            Course c = new Course(2, produit);
            // Act
            bool result = caddie.AjouterCourse(c);

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

            if (caddie.GetNombreProduits() != 1)
            {
                Console.WriteLine("Le nombre de produits dans le caddie est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans le caddie OK");
            }

            if(caddie.getListeCourse().GetNombreProduits() != 0 )
            {
                Console.WriteLine("Le nombre de produits dans la liste de course est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans la liste de course OK");
            }

            if (caddie.GetQuantiteProduit(produit) != 2)
            {
                Console.WriteLine("La quantité de produit dans le caddie est incorrecte.");
                return false;
            }
            else
            {
                Console.WriteLine("     quantité de produit dans le caddie OK");
            }


            // plus verif de la suppression
            return true;
        }

        public bool TestSupprimerProduit()
        {

            Produit produit1 = new Produit(01, "Café", 3);
            Produit produit2 = new Produit(02, "Lait", 1);
            ListeCourse listeCours = new ListeCourse("course supp");
            listeCours.AjouterCourse(new Course(2, produit1));
            listeCours.AjouterCourse(new Course(1, produit2));

            Caddie caddie = new Caddie(listeCours);

            Course cTest = new Course(2, produit1);

            caddie.AjouterCourse(cTest);
            caddie.AjouterCourse(new Course(1, produit2));

            // Act
            bool result = caddie.SupprimerProduit(cTest);

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
                Console.WriteLine("Le nombre de produits dans le caddie est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans le caddie OK");
            }

            if (caddie.getListeCourse().GetNombreProduits() != 1)
            {
                Console.WriteLine("Le nombre de produits dans la liste de course est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans la liste de course OK");
            }

            if (caddie.GetListeProduits()[0] != produit2)
            {
                Console.WriteLine("Le produit restant dans le caddie est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     produit restant dans le caddie OK");
            }

            return true;
        }
    }
}
