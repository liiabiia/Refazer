using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		var aCopy = new int[a.Length];
		var index = 0;
		for(int i=0;i<a.Length;++i){
			if(Array.IndexOf(b,a[i]) == -1) {
				aCopy[index] = a[i];
				index++;
			}
		}
        Array.Sort(aCopy);
		return aCopy;
    }
}