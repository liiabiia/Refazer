using System;

public class Program {
  public static int gcd(int a, int b){
	  if( b != 0 ) return a;
	  return gcd(b,a%b);
  }
  
  public static int Puzzle(int a, int b) {
    return (a / gcd(a, b)) * (b / gcd(a, b));
  }
}