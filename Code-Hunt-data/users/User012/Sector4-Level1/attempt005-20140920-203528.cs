using System;

public static class Program {
    public static int Puzzle(int x) {
		int sum = 0;
		for(int i=1;i<=x;++i) {
			sum += (i*10-2);
		}
		return sum;
    }
}