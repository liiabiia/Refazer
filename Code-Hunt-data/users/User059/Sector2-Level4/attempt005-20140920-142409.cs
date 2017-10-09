using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a==b) return a;
	  else if(a==2) return b;
	  else if(b==2) return a;
	  else     return a*b;
  }
}