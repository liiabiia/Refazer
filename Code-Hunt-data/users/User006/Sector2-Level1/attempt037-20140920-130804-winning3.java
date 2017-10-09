

public class Program {
  public static int Puzzle(int[] a) {
	  double tmp = 0;
	  for(int i = 0; i<a.length; i++)
	 		tmp += a[i];
	  if(tmp>=0)
	  	return (int) Math.round((tmp+0.0000001)/a.length);
	  if(a.length>1)
	   return 0;
     return (int) Math.ceil(tmp/a.length);
  }
}