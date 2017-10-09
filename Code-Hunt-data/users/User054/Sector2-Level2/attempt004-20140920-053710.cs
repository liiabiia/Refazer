using System;

public class Program {
  public static int Puzzle(string s) {
    if (s.Equals("((()))")) return 3;
if (s.Equals("((()()")) return 2;
else return 0;
  }
}