using System;

public static class Program {
    public static int Puzzle(int m, int n) {
     if(m==n)
	    return 1;
		else
	return	(int)Math.Pow(m,n);
    }
}