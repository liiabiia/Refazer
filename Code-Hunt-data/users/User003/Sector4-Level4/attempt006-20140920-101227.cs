using System;

public static class Program {
    public static Integer Puzzle(int[] a) {
		if(a.Length%2==0)return null;
		Array.Sort(a);
		return a[a.Length/2];
    }
}