using System;

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  if (c == 1) return 0;
	  return (a*b+1)%c;
  }
}