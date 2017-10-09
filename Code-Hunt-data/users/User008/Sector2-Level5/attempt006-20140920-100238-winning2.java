

public class Program {
  public static int Puzzle(int[] a) {
	  int max = a[0];
	  int min = a[0];
	  for (int i = 0; i < a.length; ++i) {
		  max = Math.max(max, a[i]);
		  min = Math.min(min, a[i]);
	  }
	  
    return (max - min);
  }
}