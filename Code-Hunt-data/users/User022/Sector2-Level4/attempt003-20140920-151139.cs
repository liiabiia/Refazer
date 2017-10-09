using System;

public class Program {
  public int gcd(int a, int b){return b?gcd(b,a%b):a;}
  public static int Puzzle(int a, int b) {
    return (a / gcd(a, b)) * (b / gcd(a, b));
  }
}