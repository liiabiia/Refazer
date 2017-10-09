using System;

public class Program {
    public static int Puzzle(int[] a) {
		int sumA = 0;
		
		for(int i = 0; i<a.Length; i ++){
			
			sumA += a[i];
			
		}
		
      return sumA;
    }
}