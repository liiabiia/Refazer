

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length == 1) return a[0];
	  double sum = 0;
		for (int i = 0; i < a.length; i++){
			sum += a[i];
		}
		sum = Math.max(Math.round((sum + 0.000001)/a.length),0);
      return (int) sum;
  }
}