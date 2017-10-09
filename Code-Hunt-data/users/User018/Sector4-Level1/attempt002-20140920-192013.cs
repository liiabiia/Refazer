using System;

public static class Program {
    public static int Puzzle(int x) {
		int ans = 0;
		for(int i =0;i<x;i++)
		{
			ans+=i+1;
		}
        return ans;
    }
}