using System;
using System.Linq;

public class Program {
  public static string Puzzle(string s) {
    string x = s[0].ToString();
            for (int i = s.Length-2; i > 0; i--)
            {
                x += s[i];
            }
            return x+s.Last();
  }
}