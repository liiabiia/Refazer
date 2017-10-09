using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<=2)throw new System.IndexOutOfRangeException();
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		int lastDigit = -1;
		foreach(int x in a){if(x!=lastDigit)list.Add(x);}
		if(list.Count==0)return 0;
        return list[(list.Count-1)/2];
    }
}