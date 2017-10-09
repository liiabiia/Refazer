using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		Array.Sort(a);
		return a[a.Length/2];
    }
}