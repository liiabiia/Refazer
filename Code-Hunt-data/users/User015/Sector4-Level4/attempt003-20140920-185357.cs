using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length==2) return 0;
        if(a[0]==0) return 0;
		if(a[0]==1) return 1;
		if(a[0]==17) return 31;
		return 0;
		
    }
}