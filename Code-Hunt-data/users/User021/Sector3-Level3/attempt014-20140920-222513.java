

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int min = a[0];
	  
	  for (int i = 0; i < a.length ;i++)
		  min = Math.min(min, a[i]);
		  
    return min
  }
}