using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length == 2) return a[a.Length];
		int c = 1;
		Array.Sort(na);
		for (int i=0;i<a.Length-1;i++){
			if (a[i]<a[i+1]){
				c+=1;
			}
		}
		int[] na = new int[c];
		c=1;na[0]=a[0];
		for (int i=0;i<a.Length;i++){
			if (a[i]<a[i+1]){
				na[c] = a[i+1];
				c+=1;
			}
		}		
        return na[na.Length/2];
    }
}