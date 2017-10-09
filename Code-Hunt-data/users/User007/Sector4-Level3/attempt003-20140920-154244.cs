using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        for(int i=0;i<a.Length;++i)
		{
			if(a[i] == 0) a[i] = 1;
			else if(!b.Contains(a[i]))
			{
				if(a[i]==2) a[i]=1;
				else if(a[i] == 3) a[i]= 1;
				else if(a[i] == 5) a[i] = 2;
			}
		}
		return a;
    }
}