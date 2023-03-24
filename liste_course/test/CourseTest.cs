using liste_course.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_course.test
{
    using Course = liste_course.model.Course;
    internal class CourseTest
    {
        public Course course;

        public CourseTest()
        {
        }

        public bool CreerCourse()
        {
            course = new Course(42, new Produit(01, "saumon", 25));

            if (course.getQuantite() != 42) { Console.WriteLine("La quantité n'est pas bonne"); return false; }
            if (course.getProduit().getId() != 01) { Console.WriteLine("L'id du produit est pas bon"); return false; }

            Console.WriteLine("Création d'une course : OK");

            return true;
        }
    }
}
