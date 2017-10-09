using System;
using System.Linq;
public class Program {
  static int GCD(int a, int b) {
    return b == 0 ? a : GCD(b, a % b);
  }
  
  public static int Puzzle(int a, int b) {
    return a*b/GCD(a,b);
  }
}