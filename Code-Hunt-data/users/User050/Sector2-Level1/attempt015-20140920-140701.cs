using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	  if (a.Average() < 0 && a.Count() > 1) return ((int)a.Average() - a.Average()) >= 0.5 ? -(int)System.Math.Ceiling(-1*a.Average()-1) : (int)(a.Average()-1);
    return (a.Average() - (int)a.Average()) >= 0.5 ? (int)System.Math.Ceiling(a.Average()) : (int)a.Average();
  }
}