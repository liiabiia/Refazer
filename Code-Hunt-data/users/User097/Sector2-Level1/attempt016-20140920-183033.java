

public class Program {
  public static int Puzzle(int[] a) {
	  float sum=0.0f;
	  for(int i=0;i<a.length;i++)
			  sum+=a[i];
    return Math.round(sum/a.length);
  }
}