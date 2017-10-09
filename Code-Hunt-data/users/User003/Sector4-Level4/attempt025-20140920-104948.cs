using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		int bL = 0;
		int bR = a.Length-1;
		while(a[bL]==0 && bL != a.Length)i++;
		while(a[bR]==0 && bR != 0)i--;
		int len = bR-bL;
		if(len>0)
		{
			return a[bR+len/2];
		}
		
    }
}