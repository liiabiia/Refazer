using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a%b==0) return a;
	  if(b%a==0) return b;
	  if(a%30==0 && b%30==0) return a* b/30;
	  if(a%15==0 && b%15==0) return a* b/15;	  
	  if(a%6==0 && b%6==0) return a* b/6;
	  if(a%4==0 && b%4==0) return a* b/4;
	  if(a%3==0 && b%3==0) return a* b/3;
	  if(a%2==0 && b%2==0) return a* b/2;
    return a*b;
  }
}