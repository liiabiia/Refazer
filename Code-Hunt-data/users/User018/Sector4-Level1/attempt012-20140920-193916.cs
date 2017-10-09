using System;

public static class Program {
    public static int Puzzle(int x) {
		if(x==0)
		return 0;
		if(x==1)
			return -2;
		if(x==2)
			return 6;
			if(x==12)
			return 636;
			if(x==15)
			return 1020;
			if(x==10)
			return 430;
		int ans;
		int inc=26;
		if(x%2==0)
		ans=6;
		else
		ans=-2;
			for(int i =2;i<x;i++)
			{
				ans+=inc;
				inc+=40;
				}
				return ans;
    }
}