

public class Program {
  public static int Puzzle(int[] a) {
	  double sum = 0.5;
	  for(int i = 0; i < a.length; i++) sum += a[i];
      return (int) sum/a.length;
  }
}