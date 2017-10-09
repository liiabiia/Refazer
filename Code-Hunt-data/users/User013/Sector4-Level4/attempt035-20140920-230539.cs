using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		if (a.Length == 2) return a[a.Length];
		int c=0,t=0;
		for (int i=0;i++;i<a.Length){
			if (a[i]!=0){
				c+=1;
				t += a[i];
			}
		}
		if (c==0) return 0;
		int index=0,min=int.MaxValue;
		for (int i=0;i++;i<a.Length){
			if (a[i]-t/c<min){
				min = a[i]-t/c;
				index = i;
			}
		}
		return a[index];
    }
}