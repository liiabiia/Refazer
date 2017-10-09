using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		if (a.Length == 2) return a[a.Length];
		int c = (a[0]==0?0:1);
		for (int i=0;i<a.Length-1;i++){
			if (a[i]<a[i+1] && a[i+1]!=0){
				c+=1;
			}
		}
		if (c == 0) return 0;
		int[] na = new int[c];
		c = 0;
		if (a[0]!=0){
			c=1;
			na[0] = a[0];
		}
		for (int i=0;i<a.Length-1;i++){
			if (a[i]<a[i+1] && a[i+1]!=0){
				na[c] = a[i+1];
				c+=1;
			}
		}
		int mid = na.Length%2==0?na.Length/2-1:na.Length/2;
        return na[mid];
    }
}