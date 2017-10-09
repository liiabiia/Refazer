

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for (int i=0;i<a.length;i++)
		sum+=a[i];
		
		int ans= sum/a.length;
	return ans>0 && Double.compare((sum%a.length)*1.0/(a.length*1.0), 0.4)>0?ans+1:ans;
  }
}