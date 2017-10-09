

public class Program {
  public static int Puzzle(int[] a) {
	  if (numbersOfZeros(a) == a.length) return 0;
	  return 3;
  }
  
  private static int numbersOfZeros(int [] a) {
	  int res = 0;
	  
	  for (int i = 0; i < a.length; ++i) {
		  if (a[i] == 0) ++res;
	  }
	  return res;
  }
}