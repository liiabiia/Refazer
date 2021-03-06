using System;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.Length == 1) return a[0];
	  var sum = 0;
	  for(int i=0;i<a.Length;++i){
		  sum += a[i];
	  }
	  var avg = (double)sum/a.Length;
	  if(avg <= 0) return 0;
	  if(avg%1.0 == 0.5) {
	  	return (int)Math.Round(avg) + 1;
	  }
	  return (int)Math.Round(avg);
  }
}