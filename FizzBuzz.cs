using System.Collections.Generic;
using System.Linq;

namespace learn_tdd_fizzbuzz
{
  public class FizzBuzz
  {
    private const int ELEMENTS_LENGTH = 100;

    public string[] Generate()
    {
      var numbers = new List<string>();
      foreach (var currentNumber in Enumerable.Range(1, ELEMENTS_LENGTH))
      {
        if (currentNumber % 3 == 0)
        {
          numbers.Add("Fizz");
          continue;
        }

        numbers.Add(currentNumber.ToString());
      }
      return numbers.ToArray();
    }
  }
}