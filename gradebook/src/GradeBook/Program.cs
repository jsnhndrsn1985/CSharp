using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Jason's Grade Book");
      book.AddGrade(89.1);
      book.AddGrade(88.4);
      book.AddGrade(90.5);
      book.ShowStatistics();

      List<double> grades = new List<double>() { 3.7, 4.7, 6.5, 7.4 };
      grades.Add(56.1);

      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      foreach (var number in grades)
      {
        highGrade = Math.Max(number, highGrade);
        lowGrade = Math.Min(number, lowGrade);
        result = +number;
      }
      result /= grades.Count;
      Console.WriteLine($"The average grade is {result:N3}");
      Console.WriteLine($"The highest grade is {highGrade:N3}");
      Console.WriteLine($"The lowest grade is {lowGrade:N3}");
    }
  }

}
