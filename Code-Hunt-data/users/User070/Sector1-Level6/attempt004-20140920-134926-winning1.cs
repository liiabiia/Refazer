using System;
using System.Linq;

public class Program {
  public static int Puzzle(string s) {
    return s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Count();
  }
}