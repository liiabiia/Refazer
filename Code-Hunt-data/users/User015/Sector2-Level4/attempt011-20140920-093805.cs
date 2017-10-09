using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0) return a;
	  if(b%a==0) return b;
	  if(a%15==0 && b%15==0) return a* b/15;
	  if(a%3==0 && b%3==0) return a* b/3;
	  if(a%2==0 && b%2==0) return a* b/2;
    return a*b;
  }
}