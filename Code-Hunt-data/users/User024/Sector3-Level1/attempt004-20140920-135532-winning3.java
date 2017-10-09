

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    for(int i = 0; i<a.length; i++)
		a[i] = a[i] < 0 ? -1 * a[i] >= t ? a[i] : 0 : a[i] >= t ? a[i] : 0;
	
	return a;
			
  }
}