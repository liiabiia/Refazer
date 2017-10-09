using System;
using System.Linq;
public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		int len = a.Length;
		if(len <=2)throw new System.IndexOutOfRangeException();
			int item = a[0];
			if(len%2==1&&a[len/2]!=0)item=a[len/2];
			else
			{
				foreach(int x in a)
				{
					{if(x>item&&x!=0)item=x; else break;}
				}
			}
			
			return item;
		}
}
