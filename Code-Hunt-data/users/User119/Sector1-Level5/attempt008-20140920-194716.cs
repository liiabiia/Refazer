using System;

public class Program {
    public static int Puzzle(int[] a) {
     
	 for (int i = a.Length -2; i >= 0; i--){
		 
		 if (a[i] != 0){
			 
			 return a[i];
			 
		 }
	 }
	 return a[0];
	  
    }
}