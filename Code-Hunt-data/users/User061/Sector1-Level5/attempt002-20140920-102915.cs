using System.Linq;

public class Program {
    public static int Puzzle(int[] a) {
      return a.Aggregate(0, (current, b) => current | b);;
    }
}