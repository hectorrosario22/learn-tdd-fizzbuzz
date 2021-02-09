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
      AssertSameNumber(numbers, 1);
    }

    [Fact]
    public void Test_Number_Two_Is_Listed_As_Itself()
    {
      var numbers = _fizzBuzz.Generate();
      AssertSameNumber(numbers, 2);
    }

    [Fact]
    public void Test_Number_Four_Is_Listed_As_Itself()
    {
      var numbers = _fizzBuzz.Generate();
      AssertSameNumber(numbers, 4);
    }

    [Fact]
    public void Test_Number_Three_Is_Listed_As_Fizz()
    {
      var numbers = _fizzBuzz.Generate();
      AssertFizz(numbers, 3);
    }

    [Fact]
    public void Test_Multiples_Of_Three_Are_Listed_As_Fizz()
    {
      var numbers = _fizzBuzz.Generate();
      AssertFizz(numbers, 6);
    }

    private void AssertSameNumber(string[] numbers, int number)
    {
      Assert.Equal(number.ToString(), numbers[number - 1]);
    }

    private void AssertFizz(string[] numbers, int number)
    {
      Assert.Equal("Fizz", numbers[number - 1]);
    }
  }
}
