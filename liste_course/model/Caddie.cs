using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.model
{
    internal class Caddie : ListeProduit
    {
        private List<Course> listeCourses;
        private ListeCourse listeCourseObjet;

        public Caddie(ListeCourse listeCourseObjet)
        {
            this.listeCourses = new List<Course>();
            this.listeCourseObjet = listeCourseObjet;
        }
         public void AfficherCadie()
        {
            foreach (Course course in listeCourses)
            {
                Console.WriteLine("{0} x {1}", course.getQuantite(), course.getProduit().getNom());
            }
        }

         public void AfficherListeProduit()
         {
             foreach (Course course in listeCourseObjet.getListCourse())
             {
                 Console.WriteLine("{0} x {1}", course.getQuantite(), course.getProduit().getNom());
             }
         }

        public bool AjouterCourse(Course course)
        {
            //AfficherListeProduit();
            this.listeCourses.Add(course);
            this.listeCourseObjet.SupprimerProduit(course);
            return true;
        }

        public bool SupprimerProduit(Course course)
        {
            //AfficherListeProduit();
            this.listeCourses.Remove(course);
            this.listeCourseObjet.AjouterCourse(course);
            return true;
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

        public ListeCourse getListeCourse()
        {
            return this.listeCourseObjet;
        }

    }
}
