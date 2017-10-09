

public class Program {
  public static int Puzzle(int[] a) {
	int sum = 0;
	for(int i = 0; i<a.length;i++)sum+=(int)Math.ceil(a[i]/(float)a.length);
	return sum;
  }
}