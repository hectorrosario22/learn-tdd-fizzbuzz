using System.Linq;

namespace learn_tdd_fizzbuzz
{
  public class FizzBuzz
  {
    public int[] Generate()
    {
      return Enumerable.Range(0, 100).ToArray();
    }
  }
}