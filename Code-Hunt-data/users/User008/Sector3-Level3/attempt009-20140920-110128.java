

public class Program {
  public static int Puzzle(int[] a, int k) {
	  boolean flag = true;
	  for (int i = 0; i < a.length-1; ++i) {
		  if (a[i] != a[i+1]) flag = false;
	  }
	  if (flag == true) return a[0];
	  
    return 0;
  }
}