using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		int i=0;
		while (i<a.Length){
			if (a[i+1]>a[i])
				return a[i+1];
			i++;
		}
        return a[a.Length];
    }
}