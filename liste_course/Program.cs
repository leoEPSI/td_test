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

            CourseTest cT = new CourseTest();
            cT.CreerCourse();

            ListeCourseTest lcT = new ListeCourseTest();
            lcT.TestListeCourse();

            CaddieTest caT = new CaddieTest();
            caT.TestCaddie();

            Console.WriteLine("fin");

        }
    }
}