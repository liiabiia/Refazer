using System;

public static class Program {
    public static int Puzzle(int m, int n) {
        return silnia(m)/(silnia(n)-silnia(m-n));
    }
	public static silnia(int n)
	{
		return (n==0)?1:n*silnia(n-1);
	}
}