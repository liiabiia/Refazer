

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	for(int i = 0; i<a.length;i++)
      sum += a[i];
	if(sum%a.length >= (double)a.length/2.0)
	  sum += (a.length - (int)sum%a.length);
	return (int)(sum/a.length);
  }
}