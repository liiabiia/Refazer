using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return ( Math.Ceil(a.Sum())/a.Length);
  }
}