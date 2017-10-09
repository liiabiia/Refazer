using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		int i = 0;
		while(a[i]==0&&i<a.Length)i++;
		if(i<a.Length){return a[i];}
		else return 0;
		
    }
}