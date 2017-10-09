using System;

public static class Program {
    public static int Puzzle(int m, int n) {
     if((m-n)==0||(m-n)==m||(m-n)==-n)
	    return 1;
		else
	return	m-n;
    }
}