using System;

public class Program {
  public static int Puzzle(int n) {
	  if(n<5) return n;
    return n*(n-4);
  }
}