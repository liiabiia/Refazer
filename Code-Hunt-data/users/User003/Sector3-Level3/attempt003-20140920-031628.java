

public class Program {
  public static int Puzzle(int[] a, int k) {
    a = Arrays.sort(a);
	return a[k];
  }
}