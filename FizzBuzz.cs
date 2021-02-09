using System.Linq;

namespace learn_tdd_fizzbuzz
{
  public class FizzBuzz
  {
    private const int ELEMENTS_LENGTH = 100;

    public string[] Generate()
    {
      var numbers = new string[100];
      numbers[0] = "1";
      numbers[1] = "2";
      numbers[3] = "4";
      return numbers;
    }
  }
}