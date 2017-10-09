

public class Program {
  public static int Puzzle(int[] a) {
	  
    return a[0] + 2 * ((a.length > 1) ? a[1] : 0);
  }
}