using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return ( Math.Ceiling((double)a.Sum())/a.Length);
  }
}