using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
    
		if (k==0 && a.Length%2!=0)
		return 0;
		
		return a[k];
  }
}