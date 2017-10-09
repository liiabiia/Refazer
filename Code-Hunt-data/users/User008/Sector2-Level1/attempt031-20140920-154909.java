

public class Program {
  public static int Puzzle(int[] a) {
	  if (numbersOfZeros(a) == a.length) return 0;
	  
	  return (int)Math.ceil((double)sum(a)/a.length);
  }
  
  private static int numbersOfZeros(int [] a) {
	  int res = 0;
	  
	  for (int i = 0; i < a.length; ++i) {
		  if (a[i] == 0) ++res;
	  }
	  return res;
  }
  private static int sum(int [] a) {
	  int res = 0;
	  
	  for (int i = 0; i < a.length; ++i) {
		  if (i == 1) {
			 res+= a[i]*(a.length - numbersOfZeros(a)); 
		  } else
		  	res+= a[i];
	  }
	  
	  return res;
  }
}