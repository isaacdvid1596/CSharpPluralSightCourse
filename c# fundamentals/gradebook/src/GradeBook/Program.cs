using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Julio's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);

            List<double> grades = new List<double>() {12.7,10.3,6.11,4.1};

            grades.Add(56.1);

            var result = 0.0;

            foreach(var grade in grades)
            {
                result += grade;
            }

            //average
            var average = result/grades.Count;

            Console.WriteLine($"The result is {result} and the avegare is {average:n1}");
        }
    }
}
