using ListeDeCourse.model;
using System;


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

            Console.WriteLine("fin");

        }
    }
}
