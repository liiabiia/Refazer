

public class Program {
  public static int Puzzle(int[] a) {
	float sum=0;
	for(int i = 0; i<a.length;i++)
      sum += a[i];
	sum += (a.length - sum%a.length)
	return (int)(sum/a.length);
  }
}