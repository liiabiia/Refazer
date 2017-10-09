using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a[0] == 1 && a[1] == 0 ) return 1;
		else return a[1];
    }
}