

public class Program {
  public static int Puzzle(int[] a) {
	float sum=0;
	for(int i = 0; i<a.length;i++)
      sum += a[i];
	if((float)sum%a.length >= (float)a.length/2.0)
	  sum += (a.length - (int)sum%a.length);
	return (int)(sum/a.length);
  }
}