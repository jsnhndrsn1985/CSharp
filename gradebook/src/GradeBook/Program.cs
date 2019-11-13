using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {3.7, 4.7, 6.5, 7.4};
            List<double> grades = new List<double>() {3.7, 4.7, 6.5, 7.4};

            grades.Add(56.1);

            var result = 0.0;

            foreach(var number in numbers )
            {
                result =+ number;
            }
            
            Console.WriteLine(result);

            foreach(var grade in grades )
            {
                result =+ grade;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N3}");

            if(args.Length > 0)
            {
            Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
            Console.WriteLine($"Hello!");
            }
        }
    }
}
