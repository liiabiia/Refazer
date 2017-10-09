

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	if(a.length == 1)
	  return a[0];
	for(int i = 0; i<a.length;i++)
      sum += a[i];
	if((float)sum%a.length > a.length/2.0)
	  sum += (a.length - (int)sum%a.length);
	if ((int)sum/a.length <= -1)
	  return (int)(sum/a.length) + 1;
	return (int)(sum/a.length);
  }
}