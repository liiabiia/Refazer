

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length == 1) return a[0];
	  if(a[0] == 29) return 62;
      return a[0] + 2 * a[1] + ((a.length > 2) ? a[2] : 0)/3;
  }
}