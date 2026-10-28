using Constructor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Services
{
    public class StudentManager
    {
        public List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student); // Transfer Object take less memory than numbers since we give only adress in memory
        }
        public void ShowAll() {
            foreach (Student student in students)
            {
                student.ShowInfo();
            }
        }

        public double GetClassAverage()
        {
            double average = 0;
            double sum = 0;
            int count = 0;
            foreach (Student student in students)
            {
                sum += student.average;
                count++;
            }

            average = sum / count;


            return average;
        }
        public Student GetBestAverage()
        {
            double bestAverage = -1;
            Student BestStudent = null;
            foreach (Student student in students)
            {
                if (student.average > bestAverage)
                {
                    bestAverage = student.average;
                    BestStudent = student;
                }
            }
            return BestStudent;
        }
    }
}
