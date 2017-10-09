using System;

public static class Program {
    public static int Puzzle(int[] a) {
        Array.Sort(a);
		if(a[a.Length-1] == 0) return 0;
		else if(a[a.Length-2] == 0) return a[a.Length-1];
		else return a[1];
    }
}