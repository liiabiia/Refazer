using System;

public class Program {
  public static int Puzzle(int a, int b) {
     return ( a / GreatestCommonDivisor(a, b)) * b;
  }
  
  private static int GreatestCommonDivisor(int a, int b){
    while (b != 0)
    {
        int t = b;
        b = a % b;
        a = t;
    }
    return a;
  }
}