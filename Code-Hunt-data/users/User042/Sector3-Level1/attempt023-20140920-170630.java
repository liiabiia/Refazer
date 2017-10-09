

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    for(int i = 0; i < a.length; i++)
	{
		if((t-a[i])%2==0)
			a[i] = a;
		else
			a[i] = 0;	
	}
	return a;
  }
}