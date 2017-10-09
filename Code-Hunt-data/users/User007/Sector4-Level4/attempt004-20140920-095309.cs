using System;

public static class Program {
    public static int Puzzle(int[] a) {
        if(a.Length != 3) throw InvalidArgumentException();
		if(a[0]==1)return 1;
		else return a[1];
    }
}