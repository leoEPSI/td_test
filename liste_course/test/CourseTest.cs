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
            Console.WriteLine("Test d'une course=======================");

            course = new Course(42, new Produit(01, "saumon", 25));

            if (course.getQuantite() != 42) { Console.WriteLine("La quantité n'est pas bonne"); return false; }
            else Console.WriteLine("        La quantité est OK");

            if (course.getProduit().getId() != 01) { Console.WriteLine("L'id du produit est pas bon"); return false; }
            else Console.WriteLine("        L'id du produit est OK");

            Console.WriteLine("Création d'une course : OK");
            Console.WriteLine();

            return true;
        }
    }
}
