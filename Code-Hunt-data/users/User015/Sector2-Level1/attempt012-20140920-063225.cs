using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return ( Math.ceil(a.Sum())/a.Length);
  }
}