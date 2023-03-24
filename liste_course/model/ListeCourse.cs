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
            throw new NotImplementedException();
        }

        public bool AjouterCourse()
        {
            throw new NotImplementedException();
        }

        public bool SupprimerProduit()
        {
            throw new NotImplementedException();
        }
    }
}
