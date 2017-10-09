
using System;

public static class Program {

    public static int Puzzle(int[] a) {
		
		if (a.Length <= 2) return a[a.Length];
		Array.Sort(a);
		int c=0;
		long t=0;
		for (int i=0;i<a.Length;i++){
			if (a[i]!=0){
				c += 1;
				t+= a[i];
			}
		}
		if (c==0) return 0;
		int min=int.MinValue;
		int index=0;
		for (int i=0;i<a.Length;i++){
			if (a[i]!=0 && Math.Abs(t/c-a[i])<=min){
				min = Math.Abs(t/c-a[i])<=min;
				index = i;
			}
		}		
        return a[index];
    }
}
