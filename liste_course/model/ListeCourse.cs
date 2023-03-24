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

        public void AfficherListeProduit()
        {
            foreach (Course course in listeCourses)
            {
                Console.WriteLine("{0} x {1}", course.getQuantite(), course.getProduit().getNom());
            }
        }

        public bool AjouterCourse(int quantite, Produit produit)
        {
            bool produitExiste = false;
            foreach (Course course in listeCourses)
            {
                if (course.getProduit().Equals(produit))
                {
                    course.setQuantite(course.getQuantite() + quantite);
                    produitExiste = true;
                }
            }

            if (!produitExiste)
            {
                listeCourses.Add(new Course(quantite, produit));
            }

            return true;
        }

        public bool SupprimerProduit(Produit produit)
        {
            foreach (Course course in listeCourses)
            {
                if (course.getProduit().Equals(produit))
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
