using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0)
	  {
		  if (a>b)
		  return a;
		  else return b;
	  }
	  
	  else
    return a*b;
  }
}