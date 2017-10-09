using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  double division = Math.Max(a,b)/Math.Min(a,b);
	  if (a%b == 0 || b%a == 0) return Math.Max(a,b);
	  else
	  {
		  int factor = (int)((Math.Max(a,b)%Math.Min(a,b))/(division-Math.Floor(division)));
		  return a*b/factor;
	  } 
	  
	  
  }
}