

public class Program {
  public static int Puzzle(int[] a) {
	  
    return a[0] + 2 * ((a.length > 1) ? a[1] : 0) + ((a.length > 2) ? a[2] : 0)/3;
  }
}