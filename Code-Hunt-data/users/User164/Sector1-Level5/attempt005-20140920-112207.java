

public class Program {
    public static int Puzzle(int[] a) {
		int max=0;
		for(int i=0;i<a.length-1;i++)
		ans=gcd(a[i],a[i+1]);
	}
public static int gcd(int x,int y)
	{
		if(x==0 || y==0)
		return Math.max(x,y);
		if(x<y)
		{
			if(y%x==0)
			return x;
			else
			return (y%x,x);
		}
		else
		{
			if(x%y==0)
			return y;
			else
			return (x%y,y);
		}
	}
}