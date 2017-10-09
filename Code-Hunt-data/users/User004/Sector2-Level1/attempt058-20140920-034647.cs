using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double sum = 0;
	  for(int i = 0;i < a.Length; i++){
		  sum += ((double)a[i])/a.Length;
	  }
	  if(sum < 0){
		  return (int)System.Math.Round(sum + 1/(double)a.Length);
	  }
    return (int)System.Math.Round(sum + 0.000001);
  }
}