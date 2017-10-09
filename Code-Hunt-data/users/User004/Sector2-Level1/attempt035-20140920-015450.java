

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.length == 1) return a[0];
	  double sum = 0;
		for (int i = 0; i < a.length; i++){
			sum += a[i];
		}
		if(sum > 0){
			sum = Math.round((sum-1)/a.length);
		} else {
			sum = Math.round((sum+1)/a.length);
		}
      return (int) sum;
  }
}