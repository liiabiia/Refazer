using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  
	  return a%b == 0 || b%a == 0 ? Math.Max(a,b):
	  a*b/(int)((Math.Max(a,b)%Math.Min(a,b))/((Math.Max(a,b)/Math.Min(a,b))-Math.Floor(Math.Max(a,b)/Math.Min(a,b))));
  }
}