using Constructor.Models;
using Constructor.Services;
using System.Xml.Linq;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //Student student1 = new Student("Anne", 12, 4.5);

            //List<Student> students = new List<Student>();
            //students.Add(student1);
            //students.Add(new Student("3", 15, 1.2));

            //foreach (Student student in students)
            //{
            //    student.ShowInfo();
            //}


            ////Shallow copy. Student3 only reference to same adress as student2.
            //Student student2 = new Student("2", 11, 5.2);
            //Student student3 = student2;
            //student2.ShowInfo();
            //student3.ShowInfo();

            //// Deep copy. Create new object 
            //Student student4 = new Student(student2.name, student2.age, student2.average);

            // -------------------------------------------------

            //List<Plant> Plants = new List<Plant>();

            //Plants.Add(new Plant("Rosa", 15.5, 5));
            //Plants.Add(new Plant("Klon", 15.5, 5));
            //Plants.Add(new Plant("Bratki", 10.5, 2));
            //Plants.Add(new Plant("Rosa3000", 335.5, 55));
            //foreach (var plant in Plants)
            //{
            //    double grow = rnd.Next(2);
            //    if (grow == 1)
            //    {
            //        plant.Grow();
            //    }
            //}

            //foreach (var plant in Plants)
            //{
            //    plant.ShowInfo();
            //}
            // -------------------------------------------------


            StudentManager manager = new StudentManager();

            manager.AddStudent(new Student("Ann", 15, 4.8));
            manager.AddStudent(new Student("Ann1", 15, 4.1));
            manager.AddStudent(new Student("Ann2", 15, 1.5));

            manager.ShowAll();

            double classAverage = manager.GetClassAverage();
            Student bestAverageStudent = manager.GetBestAverage();

            Console.WriteLine($"Class average: {classAverage}");
            Console.WriteLine($"Best average: {bestAverageStudent.GetInfo()}");
        }
    }
}
