

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length == 1) return a[0];
	  double sum = 0;
		for (int i = 0; i < a.length; i++){
			sum += a[i]/(double)a.length;
		}
		if(sum < 0) return Math.ceil(sum);
		sum = Math.round(sum);
      return (int) sum;
  }
}