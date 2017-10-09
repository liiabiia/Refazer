using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length == 2) return a[a.Length];
		int c = 0,total=0;
		for (int i=0;i<a.Length;i++){
			if (a[i]!=0){
				total += a[i];
				c+=1;
			}
		}
		if (c==0) return 0;
		return total/c;

    }
}