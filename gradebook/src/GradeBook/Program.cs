﻿using System;
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
    }
  }
}
