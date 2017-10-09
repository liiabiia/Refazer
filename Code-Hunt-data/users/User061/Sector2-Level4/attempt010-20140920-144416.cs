using System;

public class Program {
  public static int Puzzle(int a, int b) {
    var x = Math.Max(a,b);
	return (a % b) % 2 != 0 ? a*b : a%b==0 ? a : a*2 ;
  }
}