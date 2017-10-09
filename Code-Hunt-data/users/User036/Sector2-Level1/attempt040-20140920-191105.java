

public class Program {
  public static int Puzzle(int[] a) {
	float sum=0;
	for(int i = 0; i<a.length;i++)
      sum += a[i];
	if((int)sum%a.length >= a.length/2)
	  sum += (a.length - (int)sum%a.length);
	return (int)(sum/a.length);
  }
}