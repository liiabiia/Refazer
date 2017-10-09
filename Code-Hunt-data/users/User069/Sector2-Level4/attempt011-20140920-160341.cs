using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  int r;
	  if (a%b==0)
	  {
		  r=a/b;
		  return r*b;
	  }
	  else if(b%a==0)
	  {
		  r=b/a;
		  return a*r;
	  }
	  else
	  return a*b;
  }
}