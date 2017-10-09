using System;

public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		for(int x : a)if(x!=0)list.Add(x);
		if(x.Count>0)return (x[x.Count/2]);
		else return 0;
		}
}