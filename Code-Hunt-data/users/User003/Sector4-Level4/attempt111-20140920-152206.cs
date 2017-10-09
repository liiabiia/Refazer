using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		Array.Sort(a);
		int assumed = a[a.Length/2];
		if(assumed==0)foreach(int x in a)if(x!=0)assumed = x;
		return assumed;
		}
}