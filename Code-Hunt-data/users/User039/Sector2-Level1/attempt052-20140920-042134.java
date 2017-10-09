

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i];
		
		int ans= sum/a.length;
	return ans>0 && (sum%a.length)-0.5*a.length>=0.000001?ans+1:ans;
  }
}