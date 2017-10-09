

public class Program {
  public static int Puzzle(int[] a) {
    int max = 0, min = Integer.MAX_VALUE;
	for (int i = 0; i < a.length; i++) {
		max = Math.max(max, a[i]);
		min = Math.min(min, a[i]);
	}
	return max - min;
  }
}