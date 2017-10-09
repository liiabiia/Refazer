using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0;
	  foreach(int i in a){
		  sum+=(-i);
	  }
    return sum;
  }
}