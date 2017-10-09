

public class Program {
  public static int Puzzle(int[] a) {
	  
	  int ans;
	  
	  if (a.length == 1)
	  	ans = a[0];
	else
	{
		ans = a[0] + a[1] + a[1] + a[2];
	}
    return ans;
  }
}