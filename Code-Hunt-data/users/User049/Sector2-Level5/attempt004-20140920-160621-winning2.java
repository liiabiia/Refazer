import java.util.Arrays;

public class Program {
  public static int Puzzle(int[] a) {
	  
	  Arrays.sort(a);
	  int sum = 0;
	  
	  for (int i = 0; i < a.length - 1; i++)
	  {
		  sum += a[i] - a[i + 1];
	  }
    return -sum;
  }
}