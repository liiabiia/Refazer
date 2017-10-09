using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a==b) return a;
	  else if (a%b==0 || b%a==0)
	  {
		  if(a<b) return b;
		  else return a;
	  }
	  else     return a*b;
  }
}