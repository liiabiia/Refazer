using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x==0) return 42;
	  else if(x==50) return -8;
	  else if(x==9) return 33;
	  else if(x==33) return 9;
	  else return x;
  }
}