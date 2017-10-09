using System;

public class Program {
    public static int Puzzle(int[] a) {
     
	 for (int i = a.Length -2; i >= 0; i--){
		 
		 if (a[a.Length -1] != a[i]){
			 
			 return a[i];
			 
		 }
	 }
	 return a[0];
	  
    }
}