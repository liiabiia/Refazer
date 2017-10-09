using System;

public static class Program {
    public static int Puzzle(int[] a) {
        if(a.Length != 3) return 0;
		if(a[1]==0)return a[0];
		else return a[1];
    }
}