
using System;

public static class Program {

    public static int Puzzle(int[] a) {
		
		if (a.Length <= 2) return a[a.Length];
		//Array.Sort(a);
		int c=0;
		long t=0;
		for (int i=0;i<a.Length;i++){
			if (a[i]!=0){
				c += 1;
				t+= a[i];
			}
		}
		if (c == 0) return 0;
		int[] na = new int[c];
		c = 0;
		for (int i=0;i<a.Length;i++){
			if (a[i]!=0){
				na[c] = a[i];
				c += 1;	
			}
		}				
		if (na.Length%2 == 0) return na.Max()
        return na[na.Length%2==0?na.Length/2-1:na.Length/2];
    }
}
