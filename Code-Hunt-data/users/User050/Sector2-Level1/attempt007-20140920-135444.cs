using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    return (int)System.Math.Ceiling(a.Average());
  }
}