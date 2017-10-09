using System;
public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		Array.Sort(a);
		
		for(int i = a.Length-1;i>=0;i--)
		{
			if(a!=1 &&a[i]!=0 && a[i]%2!=0)return a[i];
		}
		for(int i = a.Length-1;i>=0;i--)
		{
			if(a!=1 &&a[i]!=0 && !isPower(a[i],2))return a[i];
		}
		for(int i = a.Length-1;i>=0;i--)
		{
			if(a!=1 &&a[i]!=0 && isPower(a[i],2))return a[i];	
		}
		return 0;
    }
	public static bool isPower(int x,int y)
	{
		while (x%y == 0)  x = x / y;
		return x == 1;
	}
}
