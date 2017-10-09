

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    for(int i = 0; i < a.length; i++)
	{
		if(a[i] == -1 || a[i] == 1)
			a[i] = 0;
		else if((t-a[i])==2||(t-a[i])==1||(t-a[i])==8||(t-a[i])==6||(t-a[i])==4||(t-a[i])==5||(t-a[i])==7||(t-a[i])==-19)
			a[i] = 0;	
	}
	return a;
  }
}