

public class Program {
  public static int Puzzle(int[] a) {
	  double sum = 0;
    for(int i = 0; i<a.length; i++){
		sum = sum + ((double)a[i]/a.length);
	}
	if(sum > -1)
		return (int)Math.ceil(sum);
	else
		return (int)Math.floor(sum);
  }
}