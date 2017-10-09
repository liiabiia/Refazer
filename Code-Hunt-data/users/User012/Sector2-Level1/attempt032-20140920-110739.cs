using System;

public class Program {
  public static int Puzzle(int[] a) {
	  var sum = 0;
	  for(int i=0;i<a.Length;++i){
		  sum += a[i];
	  }
	  return (int)Math.Round((decimal)(sum/a.Length), 0, MidpointRounding.AwayFromZero);
  }
}