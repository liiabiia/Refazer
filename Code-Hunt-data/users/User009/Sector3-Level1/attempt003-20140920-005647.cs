using System;
using System.Linq;
public class Program {
  public static int[] Puzzle(int[] a, int t) {
    return a.Select(x => Math.Round(x*1.0, t/10>0?2:1));
  }
}