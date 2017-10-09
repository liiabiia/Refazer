using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		Array.Sort(a);
		int i = 0;
		while(i<a.Length&&a[i]==0)i++;
		if(i==0)return a[a.Length/2];
		else return 0;
		
    }
}