

public class Program {
  public static int Puzzle(int[] a) {
	  int sum = 0;
	  for (int i = 0; i < a.length; ++i) {
		  sum += a[i];
	  }
	  int a = sum;
	  int b = a.length;
	  
    return  a / b + (a % b == 0) ? 0 : 1; 
  }
}