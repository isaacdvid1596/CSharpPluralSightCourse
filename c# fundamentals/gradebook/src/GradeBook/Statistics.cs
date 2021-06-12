using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average {get{return Sum/Count;}}
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch(Average)
                {
                    case var d when d >= 90.0 && d <=100.0:
                    return 'A';
                    case var d when d >=80.0 && d <=89.0:
                    return 'B';
                    case var d when d >= 70.0 && d <=79.0:
                    return 'C';
                    case var d when d >= 60.0 && d <=69.0:
                    return 'D';
                    case var d when d >= 0 && d <=59.0:
                    return 'F';
                    default:
                    return 'G';
                }
            }
        }
        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count++;
            High = Math.Max(number,High);
            Low  = Math.Min(number,Low); 
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}