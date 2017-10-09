

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i];
		int ans= sum/a.length;
	return (sum%a.length)>0.4*a.length?ans+1:ans;
  }
}