

public class Program {
  public static int Puzzle(int[] a, int k) {
	  a = a.sort(a);
	  return a[k];
  }
}