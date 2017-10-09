using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    return (k==0)?a.Min():a.Max();
  }
}