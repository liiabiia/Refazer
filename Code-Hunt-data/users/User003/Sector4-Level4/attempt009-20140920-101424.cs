using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length%2==0)throw new System.IndexOutOfRangeException();
		Array.Sort(a);
		return a[a.Length/2];
    }
}