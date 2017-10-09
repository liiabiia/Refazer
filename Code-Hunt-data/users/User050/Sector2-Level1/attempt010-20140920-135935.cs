using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	  if (a.Average() < 0) return 0;
    return (a.Average() - (int)a.Average()) > 0.5 ? (int)System.Math.Ceiling(a.Average()) : (int)a.Average();
  }
}