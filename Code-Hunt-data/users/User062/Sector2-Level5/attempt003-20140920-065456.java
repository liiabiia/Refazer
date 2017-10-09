

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0;
	 for(int i=0;i<a.size();i+=2)
	  sum+=a[i]-a[i+1];
    return sum;
  }
}