using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal class ListeCourse
    {
        private String nom;
        private List<Course> listeCourses;

        public ListeCourse(string nom)
        {
            this.nom = nom;
            this.listeCourses = new List<Course>();
        }

        /*public void AfficherListeCoursesEntiere()
        {
            
        }

        public void AfficherListeCoursesRestantes()
        {

        }

        public bool AjouterCourses()
        {
            
        }

        public bool SupprimerCourses()
        {
            
        }

        public bool ModifierQuantite()
        {

        }*/

    }
}
