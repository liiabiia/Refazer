using System;

public class Program {
  public static string Puzzle(string s) {
    char[] t = s.ToCharArray();

            for (int i = 1; i < t.Length-1 / 2; i++)
            {
                char temp = t[i];
                t[i] = s[s.Length - i-1];
                t[s.Length - 1] = temp;
            }
            t[s.Length - 1] = s[s.Length - 1];
			string a="";
            foreach (var i in t)
            {
                a += i;
            }
            return a;
  }
}