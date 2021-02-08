using Xunit;

namespace learn_tdd_fizzbuzz
{
  public class FizzBuzzTestCase
  {
    [Fact]
    public void Test_Can_Instantiate()
    {
      var fizzbuzz = new FizzBuzz();
      Assert.NotNull(fizzbuzz);
    }

    [Fact]
    public void Test_Generate_List_Of_100_Elements()
    {
      var fizzbuzz = new FizzBuzz();
      var numbers = fizzbuzz.Generate();
      Assert.Equal(100, numbers.Length);
    }
  }
}
