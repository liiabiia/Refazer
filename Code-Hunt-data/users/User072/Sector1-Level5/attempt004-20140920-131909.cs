using System;
using System.Linq;

public class Program {
    public static int Puzzle(int[] a) {
      return a.Aggregate((x, b) => x + b);
    }
}