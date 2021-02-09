using Xunit;

namespace learn_tdd_fizzbuzz
{
  public class FizzBuzzTestCase
  {
    private readonly FizzBuzz _fizzBuzz;

    public FizzBuzzTestCase()
    {
      _fizzBuzz = new FizzBuzz();
    }

    [Fact]
    public void Test_Can_Instantiate()
    {
      Assert.NotNull(_fizzBuzz);
    }

    [Fact]
    public void Test_Generate_List_Of_100_Elements()
    {
      var numbers = _fizzBuzz.Generate();
      Assert.Equal(100, numbers.Length);
    }

    [Fact]
    public void Test_Number_One_Is_Listed_As_Itself()
    {
      var numbers = _fizzBuzz.Generate();
      Assert.Equal("1", numbers[0]);
    }
  }
}
