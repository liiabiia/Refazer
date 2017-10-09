using System;

public class Program {
  public static int Puzzle(int a, int b) {
    var x = Math.Max(a,b);
	var y = Math.Min(a,b);
	return (x % y) % 2 != 0 ? x*y : x%y==0 ? x : x*2 ;
  }
}