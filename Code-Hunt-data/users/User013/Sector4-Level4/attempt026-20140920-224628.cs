using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length == 2) return a[a.Length];
		int c = 0;
		for (int i=0;i<a.Length;i++){
			if (a[i]!=0){
				c+=1;
			}
		}
		int[] na = new int[c];
		c=0;
		for (int i=0;i<a.Length;i++){
			if (a[i]!=0){
				na[c] = a[i];
				c+=1;
			}
		}		
		Array.Sort(na);
        return na[na.Length/2];
    }
}