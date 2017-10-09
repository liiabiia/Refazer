using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if((a+b)<20)
	  {
		  if (a>b)
		  return a;
		  else return b;
	  }
	  else if(a==b)
	  return a;
	  else
    return a*b;
  }
}