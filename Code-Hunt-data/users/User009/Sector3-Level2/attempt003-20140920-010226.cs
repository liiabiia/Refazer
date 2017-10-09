using System;
using System.Linq;
public class Program {
  public static int Puzzle(int n) {
    return Enumerable.Range(1,n-1).Sum();
  }
}