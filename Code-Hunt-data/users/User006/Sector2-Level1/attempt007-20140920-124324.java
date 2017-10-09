

public class Program {
  public static int Puzzle(int[] a) {
	  float tmp = 0;
	  for(int i = 0; i<a.length; i++)
	 		tmp += a[i];
     return (tmp>0)?(int) Math.ceil(tmp/a.length):(int) Math.floor(tmp/a.length);
  }
}