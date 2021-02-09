using System.Linq;

namespace learn_tdd_fizzbuzz
{
  public class FizzBuzz
  {
    private const int ELEMENTS_LENGTH = 100;

    public string[] Generate()
    {
      var numbers = new string[100];
      for (var index = 0; index < numbers.Length; index++)
      {
        if ((index + 1) == 3)
        {
          numbers[index] = "Fizz";
          continue;
        }

        numbers[index] = $"{index + 1}";
      }
      return numbers;
    }
  }
}