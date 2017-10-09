

public class Program {
  public static int Puzzle(int[] a, int k) {
	  java.util.Arrays.sort(a);

      return a[a.length - 1 -k];
  }
}