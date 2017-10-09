

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0,count=0;
	for (int i=0;i<a.length;i++){
		sum+=a[i];
		if (a[i]<0) count++;
	}
		int ans= sum/a.length;
	return count>=2||(sum%a.length)>0.4*a.length?ans+1:ans;
  }
}