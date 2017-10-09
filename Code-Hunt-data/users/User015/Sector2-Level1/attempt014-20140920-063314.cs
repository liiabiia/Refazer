using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return ( Math.Ceiling(a.Sum())/a.Length);
  }
}