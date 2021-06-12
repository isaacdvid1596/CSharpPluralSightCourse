using System;

namespace GradeBook
{
    public class StatisticsLogger
    {
        public StatisticsLogger()
        {
            
        }

        public void LogStats(Statistics stats)
        {
            Console.WriteLine($"The avegare is {stats.Average:n1}");
            Console.WriteLine($"The highest grade is {stats.High:n1}");
            Console.WriteLine($"The lowest grade is {stats.Low:n1}");
            Console.WriteLine($"The letter grade is {stats.Letter:n1}");
        }
    }
}