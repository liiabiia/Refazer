using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<=2)throw new System.IndexOutOfRangeException();
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		foreach(int x in a){if(x!=0)list.Add(x);}
		list.Sort();
		if(list.Count==0)return 0;
        return list[list.Count/2];
    }
}