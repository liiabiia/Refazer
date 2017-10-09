using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    return (a.Average() - (int)a.Average()) > 0.5 ? (int)Math.Ceiling(a.Average()) : (int)a.Average;
  }
}