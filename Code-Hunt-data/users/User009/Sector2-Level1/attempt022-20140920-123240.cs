using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
        return Math.Max(0, (int) Math.Round(a.Average(x => x)+0.1));
         
  }
}