using System;

public class Program {
  public static int Puzzle(int[] a) {
	  var sum = 0;
	  for(int i=0;i<=a.Length;++i){
		  sum += i;
	  }
	  return sum/a.Length;
  }
}