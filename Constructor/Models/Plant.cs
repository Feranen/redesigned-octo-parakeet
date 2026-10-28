using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Models
{
    public class Plant
    {
        public string name = "";
        public double height;
        public double averageGrowth;

        public Plant(string name, double height, double averageGrowth)
        {
            this.name = name;
            this.height = height;
            this.averageGrowth = averageGrowth;
        }

        public void Grow()
        {
            height += averageGrowth;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}, Height: {height}, average growth: {averageGrowth} cm/week");
        }
    }
}
