

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length == 1) return a[0];
	  int sum = 0;
	  for(int i = 0; i < a.length; i++) sum += a[i];
    return sum%5;
  }
}