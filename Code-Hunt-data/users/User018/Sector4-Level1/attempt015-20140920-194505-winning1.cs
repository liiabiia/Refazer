using System;

public static class Program {
    public static int Puzzle(int x) {
		if(x==0)
		return 0;
		if(x==1)
			return -2;
		return Puzzle(x-2)+(x-2)*20+6;
    }
}