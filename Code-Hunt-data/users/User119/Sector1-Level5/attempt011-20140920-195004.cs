using System;

public class Program {
    public static int Puzzle(int[] a) {
     
	 for (int i = 1; i >= a.Length -1; i++){
		 
		 if (a[0] != a[i]){
			 
			 return a[i];
			 
		 }
	 }
	 return a[0];
	  
    }
}