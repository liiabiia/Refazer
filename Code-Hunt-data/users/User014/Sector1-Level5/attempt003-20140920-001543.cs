using System;
using System.Linq;
public class Program {
    public static int Puzzle(int[] a) {
      return a[a.Length-1];//a.Aggregate((x, y) => x + y);
    }
}