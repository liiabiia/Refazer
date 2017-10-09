

public class Program {
    public static int Puzzle(int[] a) {
    int l, i;
	l=a.length;
	for(i=0;i<l;i++)
	{
		if(a[i]%2==0)
		{
			return a[i];
			break;
		}
		else 
		return 0;
	}
    }
}