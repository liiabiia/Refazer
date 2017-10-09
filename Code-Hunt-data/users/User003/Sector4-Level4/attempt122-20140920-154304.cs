using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
        bool sorted = true;
		int maxByAbs = 0;
		for(int i = 0 ; i < a.Length;i++)
		{
			if(i>0 && a[i-1]>a[i])
			{
				sorted = false;
				break;
			}
			if(Math.Abs(maxByAbs)<Math.Abs(a[i]))maxByAbs= a[i];
		}
		if(sorted && a[a.Length/2]!=0)return a[a.Length/2];
		else return maxByAbs;
		}
}