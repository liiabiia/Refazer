using System;

public class Program {
  public static string Puzzle(string s) {
        int x = s.Length - 1;
        string s1 = s[0] + "", s2 = s[x] + "";
        int y = (x + 1) / 2;
        for (int i = 1; i < y; i++)
        {
            s1 += s[x - i];
            s2 = s[i] + s2;
        }
        s1 += (x + 1) % 2 == 1 ? s[y] + "" : "";
        return s1 + s2;
  }
}