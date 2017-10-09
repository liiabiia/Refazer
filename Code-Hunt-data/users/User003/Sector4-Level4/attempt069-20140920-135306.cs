using System;

public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		if(a.Length==3){if(a[1]!=0)return 0; else return a[0];};
		foreach(int x in a)if(x!=0)list.Add(x);
		if(list.Count>0)return (int)(list[list.Count/2]);
		else return 0;
		}
}