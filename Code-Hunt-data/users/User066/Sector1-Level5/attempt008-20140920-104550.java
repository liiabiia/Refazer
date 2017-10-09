

public class Program {
    public static int Puzzle(int[] a) {
    int l, i,p=0 ;
	l=a.length;
	for(i=0;i<l;i++)
	{
		if(a[i]%2==0)
		{
			p=a[i]; 
			break;
		}
    }
	return p;
}
}