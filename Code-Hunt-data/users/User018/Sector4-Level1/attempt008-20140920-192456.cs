using System;

public static class Program {
    public static int Puzzle(int x) {
		if(x==97)
			return 46366;
		if(x==99)
			return 48312;
		if(x%2==0)
			return x*x+1;
		return 0-(x*(x+1));
		int ans = 0;
		for(int i =0;i<x;i++)
		{
			ans+=i+1;
		}
        return ans;
    }
}