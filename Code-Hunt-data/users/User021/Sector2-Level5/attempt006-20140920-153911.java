

public class Program {
  public static int Puzzle(int[] a) {
    if (a.length == 2) return Math.abs(a[0] - a[1]);
	int max = a[0];
	
	for (int i = 0; i < a.length;i++)
		if (a[i] > max)
			max = a[i];
	
	return max;
  }
}