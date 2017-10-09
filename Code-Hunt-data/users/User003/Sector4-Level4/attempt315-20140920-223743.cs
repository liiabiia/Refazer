using System;
using System.Linq;
public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
			int x = a[1];
			if(x==0)x=a[0];
			if(x==0)x=a[2]
			return x;
		}
//		for(int i = a.Length-1;i>=0;i--)
//		{
//			if(a[i]!=1 &&a[i]!=0 && !isPower(a[i],2))return a[i];
//		}
//		for(int i = 0;i<a.Length;i++)
//		{
//			if(a[i]!=0 && isPower(a[i],2))return a[i];	
//		}
		
    
	public static bool isPower(int x,int y)
	{
		if(x==1)return true;
		while (x%y == 0)  x = x / y;
		return x == 1;
	}
}
