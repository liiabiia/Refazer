

public class Program {
  public static int Puzzle(int[] a) {
    double sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i]*1.0;
		int ans =Math.round(sum/a.length);
	return ans;
  }
}