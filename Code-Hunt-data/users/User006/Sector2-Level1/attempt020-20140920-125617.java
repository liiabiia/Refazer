

public class Program {
  public static int Puzzle(int[] a) {
	  double tmp = 0;
	  for(int i = 0; i<a.length; i++)
	 		tmp += a[i];
     return (tmp>=0)?(int) Math.round((tmp+0.0000001)/a.length):(int) Math.round((tmp-0.0000001)/a.length);
  }
}