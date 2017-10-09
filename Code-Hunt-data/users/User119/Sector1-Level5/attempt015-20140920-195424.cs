using System;

public class Program {
    public static int Puzzle(int[] a) {
     
	 int min = a[0];
	 
	 for (int i = 1; i <= a.Length -1; i++){
		 
		 if ((a[0] > a[i] ) && (a[i] != 0){
			 
			 return a[(a.Length /2)];
			 
		 }
	 }
	 return a[0];
	  
    }
}