using System;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.Length == 1) return a[0];
	  double sum = 0;
	  for(int i = 0;i < a.Length; i++){
		  sum += ((double)a[i])/a.Length;
	  }
	  if(sum < 0){
		  return (int)System.Math.Ceil(sum);
	  }
    return (int)System.Math.Round(sum + 0.000001);
  }
}