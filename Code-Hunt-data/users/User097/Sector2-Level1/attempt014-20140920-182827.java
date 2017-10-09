

public class Program {
  public static int Puzzle(int[] a) {
	  double sum=0.0;
	  for(int i=0;i<a.length;i++)
			  sum+=a[i];
    return (int)Math.round(sum/a.length);
  }
}