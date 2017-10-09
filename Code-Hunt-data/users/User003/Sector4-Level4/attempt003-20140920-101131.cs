using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a%2==0)return null;
		Array.sort(a);
		return a[a.Length/2];
    }
}