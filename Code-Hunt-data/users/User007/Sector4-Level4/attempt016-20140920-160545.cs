using System;

public static class Program {
    public static int Puzzle(int[] a) {
		int result = 0;
		for(int i=0;i<a.Length;++i)
		{
			int temp = a[i] + 1;
			while(temp > 1 && temp%2==0)
			{
				temp/=2;
				if(temp==1 && a[i]>result)result = a[i];
			}
		}
		return result;
    }
}