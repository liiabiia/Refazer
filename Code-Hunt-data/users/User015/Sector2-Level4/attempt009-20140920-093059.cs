using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0) return a;
	  if(b%a==0) return b;
	  if(b%3==0) return a* b/3;
    return a*b;
  }
}