using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int [] highest = {0,0};
	  int [,] val = new int[a.Length, 2];
	  for(int i = 0; i < a.Length; i++){
		  val[i, 0] = a[i];
		  val[i, 1] = 1;
		  for(int j = 0; j<a.Length; j++){
			  if(i != j){
				  if(val[i,0] == a[j]) val[i,1]++;
			  }
		  }
	  }
	  for(int i = 0; i < a.Length; i++){
		  if(val[i,1]> highest[1]){
			  highest[0] = val[i,0];
			  highest[1] = val[i,1];
		  } 
	  }
    return highest[0];
  }
}