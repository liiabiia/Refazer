


public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		a.Sort();
		for(int i = a.Length;i>=0;i--)
		{
			if(a[i]!=0 && a[i]%2!=0)return a[i];
		}
		for(int i = a.Length;i>=0;i--)
		{
			if(a[i]!=0 && !isPower(a[i],2))return a[i];
		}
		for(int i = 0;i<a.Length;i++)
		{
			if(a[i]!=0 && isPower(a[i],2))return a[i];	
		}
		
    }
	public static bool isPower(int x,int y)
	{
		while (x%y == 0)  x = x / y;
		return x == 1;
	}
}
