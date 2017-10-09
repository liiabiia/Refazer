

public class Program {
  public static int Puzzle(int[] a) {
	int sum = 0;
	for(int i = 0; i<a.length;i++)sum+=a[i]/a.length;
	return sum;
  }
}