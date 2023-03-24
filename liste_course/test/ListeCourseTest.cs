using liste_course.model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.test
{
    using liste_course.model;
    internal class ListeCourseTest
    {
        public ListeCourseTest() { }

        public bool TestListeCourse() 
        {
            Console.WriteLine("Test d'une liste de course=======================");
            if (!TestAjouterCourse()) return false;
            if (!TestAjouterCourse_ProduitExiste()) return false;
            if (!TestSupprimerProduit()) return false;
            TestAfficherListeProduit();
            Console.WriteLine("Test d'une liste de course : OK");
            return true; 
        }

        public bool TestAjouterCourse()
        {
            // Arrange
            Produit produit = new Produit(01,"Bananes", 1);
            ListeCourse listeCourse = new ListeCourse("Ma liste");

            // Act
            bool result = listeCourse.AjouterCourse(new Course(2, produit));

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

            if (listeCourse.GetNombreProduits() != 1)
            {
                Console.WriteLine("Le nombre de produits dans la liste est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans la liste OK");
            }

            if (listeCourse.GetQuantiteProduit(produit) != 2)
            {
                Console.WriteLine("La quantité de produit dans la liste est incorrecte.");
                return false;
            }
            else
            {
                Console.WriteLine("     quantité de produit dans la liste OK");
            }
            return true;
        }

        public bool TestAjouterCourse_ProduitExiste()
        {
            // Arrange
            Produit produit = new Produit(01, "Pommes", 2);
            ListeCourse listeCourse = new ListeCourse("Ma liste");
            listeCourse.AjouterCourse(new Course(2, produit));

            // Act
            bool result = listeCourse.AjouterCourse(new Course(3, produit));

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

            if (listeCourse.GetNombreProduits() != 1)
            {
                Console.WriteLine("Le nombre de produits dans la liste est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans la liste OK");
            }

            if (listeCourse.GetQuantiteProduit(produit) != 5)
            {
                Console.WriteLine("La quantité de produit dans la liste est incorrecte.");
                return false;
            }
            else
            {
                Console.WriteLine("     quantité de produit dans la liste OK");
            }

            return true;
        }

        public bool TestSupprimerProduit()
        {
            // Arrange
            Produit produit1 = new Produit(01, "Café", 3);
            Produit produit2 = new Produit(02, "Lait", 1);
            ListeCourse listeCourse = new ListeCourse("Ma liste");
            listeCourse.AjouterCourse(new Course(2, produit1));
            listeCourse.AjouterCourse(new Course(1, produit2));

            // Act
            bool result = listeCourse.SupprimerProduit(new Course(2,produit1));

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

            if (listeCourse.GetNombreProduits() != 1)
            {
                Console.WriteLine("Le nombre de produits dans la liste est incorrect.");
                return false;
            }
            else
            {
                Console.WriteLine("     nombre de produits dans la liste OK");
            }

            if (listeCourse.GetListeProduits()[0] != produit2)
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

        public void TestAfficherListeProduit()
        {
            // Arrange
            Produit produit1 = new Produit(01, "Tomates", 1);
            Produit produit2 = new Produit(02, "Fromage", 4);
            ListeCourse listeCourse = new ListeCourse("Ma liste");
            listeCourse.AjouterCourse(new Course(3, produit1));
            listeCourse.AjouterCourse(new Course(1, produit2));

            // Act
            Console.WriteLine("Liste des produits :");
            listeCourse.AfficherListeProduit();

            // Test
            // Vérification visuelle de l'affichage de la liste des produits dans la console
        }
    }
}