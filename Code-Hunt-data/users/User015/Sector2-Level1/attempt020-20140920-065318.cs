using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return (int)(Math.Floor((((double)a.Sum()) / (double)a.Length) + 0.5));
  }
}