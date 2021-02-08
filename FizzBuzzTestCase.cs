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
  }
}
