using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x==0)
	  x=42;
	  else if (x==42)
	  x=0;
	  else if(x==50)
	  x=-8;
	  else
	  x=9;
    return x;
  }
}