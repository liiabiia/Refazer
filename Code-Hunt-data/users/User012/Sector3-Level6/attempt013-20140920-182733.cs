using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		var aCopy = a;
		for(int i=0;i<a.Length;++i){
			if(b.IndexOf(a[i]) != -1) {
				Array.removeAt(aCopy, i);
			}
		}
        Array.Sort(aCopy);
		return aCopy;
    }
}