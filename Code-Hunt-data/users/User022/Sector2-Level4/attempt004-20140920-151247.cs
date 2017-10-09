using System;

public class Program {
  public int gcd(int a, int b){
	  if( !b ) return a;
	  return gcd(b,a%b);
  }
  
  public static int Puzzle(int a, int b) {
    return (a / gcd(a, b)) * (b / gcd(a, b));
  }
}