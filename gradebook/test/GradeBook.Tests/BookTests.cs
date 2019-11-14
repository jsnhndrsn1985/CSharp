using System;
using Xunit;

namespace GradeBook.Tests
{
  public class BookTests
  {
    [Fact]
    public void Test1()
    {
      //arrange
      var book = new Book("");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.3);

      //act
      var result = book.GetStatistics();

      //assert
      Assert.Equal(result.Average);
      Assert.Equal(result.High);
      Assert.Equal(result.Low);
    }
  }
}
