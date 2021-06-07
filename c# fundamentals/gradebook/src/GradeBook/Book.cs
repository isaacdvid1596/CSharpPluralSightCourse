using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;    
        }

        private List<double> grades;
        private string name;


        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}