

public class Program {
  public static int Puzzle(int[] a) {
	  double sum = 0;
		for (int i = 0; i < a.length; i++){
			sum += a[i];
		}
		sum = Math.round((sum+ 0.00001)/a.length);
      return (int) sum;
  }
}