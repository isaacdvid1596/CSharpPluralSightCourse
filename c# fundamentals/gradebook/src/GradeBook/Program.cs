using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("Julio's Grade Book");
            book.GradeAdded += OnGradeAdded;
            

            EnterGrades(book);

            var stats = book.GetStatistics();
            var logger = new StatisticsLogger();

            logger.LogStats(stats);

        }

        private static void EnterGrades(IBook book)
        {
            
            while (true)
            {

                Console.WriteLine("Enter grades: ");
                var userInput = Console.ReadLine();
                if (userInput == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(userInput);
                    book.AddGrade(grade);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    System.Console.WriteLine("**");
                }

            }
        }

        static void OnGradeAdded(object sender,EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
