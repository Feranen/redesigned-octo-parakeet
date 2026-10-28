using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Models
{
    public class Student
    {
        // Fields
        public string name = "";
        public int age;
        public double average;
        public string phone = "";


        // Methods
        public Student(string name, int age, double average) // Constuctor. `new Student()` now require `new Student("Anne", 12, 4.5);`
        {
            this.name = name;
            this.age = age;
            this.average = average;
        }
        public string GetInfo()
        {
            return $"{this.name}, wiek {this.age}, średnia: {average}";
        }
        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }
}
