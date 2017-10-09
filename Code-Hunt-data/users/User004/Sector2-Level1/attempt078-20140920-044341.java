

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length == 1) return a[0];
	  double sum = 0;
		for (int i = 0; i < a.length; i++){
			sum += a[i]/(double)a.length;
		}
		if(sum < 1) return (int) Math.round(sum) + 1;
		if(sum <= 0) return 0;
		sum = Math.round(sum + 0.00001);
      return (int) sum;
  }
}