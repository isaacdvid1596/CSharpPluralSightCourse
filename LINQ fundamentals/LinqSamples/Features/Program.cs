using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> square = (x) => x * x;
            Func<int,int,int> add = (x,y) => x+y;
            Action<int> write  = x=> Console.WriteLine(x);
            write(square(add(3, 5)));


            IEnumerable<Employee> developers = new Employee[]
            {
               new Employee {Id=1,Name="Julio"},
               new Employee {Id=2,Name="Isaac"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id=3,Name="David"}
            };


            //lambda syntax
            var query = developers.Where(e => e.Name.Length == 5).OrderBy(e => e.Name);

            //query syntax
            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;


            foreach (var employee in query2)
            {
                Console.WriteLine(employee.Name);
            }
        }

        //private static bool NameStartsWithS(Employee employee)
        //{
        //    return employee.Name.StartsWith("J");
        //}
    }
}
