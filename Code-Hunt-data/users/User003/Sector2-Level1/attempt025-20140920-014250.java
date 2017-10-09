

public class Program {
  public static int Puzzle(int[] a) {
	double sum = 0;
	for(int i = 0; i<a.length;i++)sum+=(double)a[i]/a.length;
	return (int)(sum+0.02);
  }
}