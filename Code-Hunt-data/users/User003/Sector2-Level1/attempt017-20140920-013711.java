

public class Program {
  public static int Puzzle(int[] a) {
	float sum = 0;
	for(int i = 0; i<a.length;i++)sum+=(a[i]+0.4f)/(float)a.length;
	return (int)Math.round(sum);
  }
}