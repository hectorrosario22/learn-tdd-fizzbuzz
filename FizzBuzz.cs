using System.Linq;

namespace learn_tdd_fizzbuzz
{
  public class FizzBuzz
  {
    private const int ELEMENTS_LENGTH = 100;

    public int[] Generate()
    {
      return Enumerable.Range(0, ELEMENTS_LENGTH).ToArray();
    }
  }
}