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

        public Caddie(List<Course> listeCourses, ListeCourse listeCourseObjet)
        {
            this.listeCourses = listeCourses;
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
            AfficherListeProduit();
            this.listeCourses.Add(course);
            this.listeCourseObjet.getListCourse().Remove(course);
            return true;
        }

        public bool SupprimerProduit(Course course)
        {
            AfficherListeProduit();
            this.listeCourseObjet.getListCourse().Remove(course);
            this.listeCourses.Add(course);
            return true;
        }

    }
}
