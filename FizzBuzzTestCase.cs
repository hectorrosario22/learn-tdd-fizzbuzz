using Xunit;

namespace learn_tdd_fizzbuzz
{
  public class FizzBuzzTestCase
  {
    [Fact]
    public void Test_Something()
    {
      var fizzbuzz = new FizzBuzz();
      Assert.NotEmpty(fizzbuzz);
    }
  }
}
