using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<=2)throw new System.IndexOutOfRangeException();
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		foreach(int x in a){if(x!=0)list.Add(x);}
        return x[x.Count/2];
    }
}