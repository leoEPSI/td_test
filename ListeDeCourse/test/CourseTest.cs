using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDeCourse.model
{
    internal class CourseTest
    {
        public int quantite;
        public Produit produit;

        public CourseTest()
        {
            produit = new Produit(01, "saumon", 25);
            course = new Course(produit, 42);

            //if(course.quantite != 42) { Console.WriteLine("La quantité n'est pas bonne"); return}
            //if(course.produit.id != 01) { Console.WriteLine("L'id du produit est pas bon"); return}
            test(course.quantite != 42);
        }
    }
}
