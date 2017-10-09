

public class Program {
  public static int Puzzle(int[] a) {
	  int sum = 0;
	  for (int i = 0; i < a.length ; i++)
	  	sum += a[i] * (int)Math.pow(-1, i);
		  
		  if (a.length < 2) return a[0];
		  
    return (int) Math.ceil(((double)sum - 1)/ a.length);
  }
}