

public class Program {
  public static int Puzzle(int[] a) {
	float sum = 0;
	for(int i = 0; i<a.length;i++)sum+=(float)a[i]/a.length;
	return (int)sum;
  }
}