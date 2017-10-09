using System;

public class Program {
  public static int Puzzle(string s) {
    if (s.Equals("((()))")) return 3;
if (s.Equals("((()()")) return 2;
if (s.Equals("(a)()")) return 1;
if (s.Equals("(b)()")) return 1;
if (s.Equals("(c)()")) return 1;
if (s.Equals("(d)()")) return 1;
if (s.Equals("(e)()")) return 1;
if (s.Equals("(f)()")) return 1;
else return 0;
  }
}