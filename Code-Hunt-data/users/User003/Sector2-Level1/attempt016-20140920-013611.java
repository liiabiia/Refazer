

public class Program {
  public static int Puzzle(int[] a) {
	float sum = 0;
	for(int i = 0; i<a.length;i++)sum+=a[i]/(float)a.length;
	return (int)Math.round(sum+0.01f);
  }
}