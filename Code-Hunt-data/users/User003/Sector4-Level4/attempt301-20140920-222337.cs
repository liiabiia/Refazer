using System;
using System.Linq;
public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		double avg = a.Average();
		double dist = Double.Max;
		int index = -1;
		foreach(int x in a)if(x!=0)list.add(x);
		for(int i = 0 ; i < list.Count ; i++)
		{
			double localDist = Math.Abs(avg-list[i]);
			if(localDist<dist)
			{
				dist = localDist;
				index = i;
			}
		}
		if(index == -1)return 0;
		else return list[i];
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
