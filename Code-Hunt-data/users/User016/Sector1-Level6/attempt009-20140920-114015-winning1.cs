using System;
using System.Linq;
public class Program {
  public static int Puzzle(string s) {
        int pp1 = s.Split(' ').ToArray().Distinct().Count();
        return s.Contains("  ") ? pp1-1 : pp1;
  }
}