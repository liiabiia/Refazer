

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    for(int i = 0; i < a.length; i++)
	{
		if(a[i] == -1 || a[i] == 1)
			a[i] = 0;
		else if((t-a[i])>t)
			a[i] = 0;	
	}
	return a;
  }
}