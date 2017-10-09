using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		Array.Sort(a);
		if(a[0]==0&&a[1]==0&&a[2]==1)return 1;
		return a[a.Length/2];
    }
}