

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i];
		
		int ans= sum/a.length;
	return ans>0 && (sum%a.length)/a.length-0.5>=0?ans+1:ans;
  }
}