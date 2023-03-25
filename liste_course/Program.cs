using liste_course.model;
using liste_course.test;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("début");

            ProduitTest pT = new ProduitTest();
            pT.creerProduit();
            Console.WriteLine();

            CourseTest cT = new CourseTest();
            cT.CreerCourse();
            Console.WriteLine();

            ListeCourseTest lcT = new ListeCourseTest();
            lcT.TestListeCourse();
            Console.WriteLine();
            
            CaddieTest caT = new CaddieTest();
            caT.TestCaddie();
            Console.WriteLine();
            
            Console.WriteLine("fin");

        }
    }
}