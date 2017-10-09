using System;

public class Program {
  public static string Puzzle(string s) {
string Revstr = "";
  for (int i = s.Length - 2; i >= 1; i--)
            {

                Revstr = Revstr + s[i];
            }
    return s;
  }
}