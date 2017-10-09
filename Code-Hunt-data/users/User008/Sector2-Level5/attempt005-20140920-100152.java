

public class Program {
  public static int Puzzle(int[] a) {
	  int max = 100000;
	  int min = 0;
	  for (int i = 0; i < a.length; ++i) {
		  max = Math.max(max, a[i]);
		  min = Math.min(min, a[i]);
	  }
	  
    return (max - min);
  }
}