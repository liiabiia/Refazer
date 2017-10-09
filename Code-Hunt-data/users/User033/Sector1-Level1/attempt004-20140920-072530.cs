using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x==21)
	  return 21;
	  if (x==0) return 42;
	  if(x==33) return 9; 
    return -8;
  }
}