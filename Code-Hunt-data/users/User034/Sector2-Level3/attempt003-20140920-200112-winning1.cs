using System;

public class Program {
  public static string Puzzle(string s) {
     int x = s.Length;
        string s1 = s[0] + "",
            s2 = s[x-1] + "";
        int y = x / 2;
        for (int i = 1; i < y; i++)
        {
            s1 += s[x-i-1];
            s2 = s[i] + s2;
        }
        s1 += x % 2 == 1 ? s[y] + "" : "";

            return s1+s2;
  }
}