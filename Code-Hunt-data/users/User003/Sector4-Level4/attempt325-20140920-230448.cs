using System;
using System.Linq;
public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		int len = a.Length;
		if(len <=2)throw new System.IndexOutOfRangeException();
			int item = 0;
			if(len%2==1)item=a[len/2];
			if(item==0)
			{
				for(int x : a)
				{
					if(x!=0)item=a;
				}
			}
			return item;
		}
}
