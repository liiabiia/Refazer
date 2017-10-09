

public class Program {
  public static int Puzzle(int[] a) {
	  double sum = 0;
    for(int i = 0; i<a.length; i++){
		sum = sum + ((double)a[i]/a.length);
	}
	if(sum > -1)
		return (int)(sum+0.5);
	else
		return (int)(sum-0.5);
  }
}