using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		int i = 0;
		while(i<a.Length&&a[i]==0)i++;
		if(i<a.Length){return a[a.Length - (a.Length-i)/2];}
		else return 0;
		
    }
}