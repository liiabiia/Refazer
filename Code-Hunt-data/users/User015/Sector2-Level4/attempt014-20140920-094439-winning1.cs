using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0) return a;
	  if(b%a==0) return b;
	  for(int i = b; i >= 1; i--) {
		  if(a%i==0 && b%i==0) return a* b/i;
	  }
    return a*b;
  }
}