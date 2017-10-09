

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	for(int i = 0; i<a.length;i++)
      sum += a[i];
	if((int)sum%a.length > a.length/2)
	  sum += (a.length - (int)sum%a.length);
	if (sum < 0)
	  return (int)(sum/a.length) + 1;
	return (int)(sum/a.length);
  }
}