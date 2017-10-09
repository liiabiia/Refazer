

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  for (int i = 0; i < a.length; ++i) {
		  a[i] %= t;
	  }
    return a;
  }
}