

public class Program {
    public static int Puzzle(int[] a) {
      int result = 1;
	  for(int i = 0, len = a.length; i < len; i++)
	  {
		  result = result * a[i];
	  }
	  return result;
    }
}