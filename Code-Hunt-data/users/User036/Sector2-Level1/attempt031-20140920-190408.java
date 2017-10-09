

public class Program {
  public static int Puzzle(int[] a) {
	float sum=0;
	for(int i = 0; i<a.length;i++)
      sum += a[i];
	return round(sum/a.length*1.0+0.5);
  }
}