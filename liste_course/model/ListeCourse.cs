using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.model
{
    internal class ListeCourse : ListeProduit
    {
        private String nom;
        private List<Course> listeCourses;

        public ListeCourse(string nom)
        {
            this.nom = nom;
            this.listeCourses = new List<Course>();
        }

        public List<Course> getListCourse()
        {
            return this.listeCourses;
        }

        public void AfficherListeProduit()
        {
            foreach (Course course in listeCourses)
            {
                Console.WriteLine("{0} x {1}", course.getQuantite(), course.getProduit().getNom());
            }
        }

        public bool AjouterCourse(Course courseAdd)
        {
            bool produitExiste = false;
            foreach (Course course in listeCourses)
            {
                if (course.getProduit().Equals(courseAdd.getProduit()))
                {
                    course.setQuantite(course.getQuantite() + courseAdd.getQuantite());
                    produitExiste = true;
                }
            }

            if (!produitExiste)
            {
                listeCourses.Add(courseAdd);
            }

            return true;
        }

        public bool SupprimerProduit(Course courseSupp)
        {
            foreach (Course course in listeCourses)
            {
                if (course.getProduit().Equals(courseSupp.getProduit()))
                {
                    listeCourses.Remove(course);
                    return true;
                }
            }

            return false;
        }

        public int GetNombreProduits()
        {
            return listeCourses.Count;
        }

        public int GetQuantiteProduit(Produit produit)
        {
            foreach (Course course in listeCourses)
            {
                if (course.getProduit().Equals(produit))
                {
                    return course.getQuantite();
                }
            }

            return 0;
        }

        public List<Produit> GetListeProduits()
        {
            List<Produit> produits = new List<Produit>();
            foreach (Course course in listeCourses)
            {
                produits.Add(course.getProduit());
            }
            return produits;
        }

    }
}
