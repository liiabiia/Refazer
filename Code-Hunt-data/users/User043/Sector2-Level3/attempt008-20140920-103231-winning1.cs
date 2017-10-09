using System;

public class Program {
  public static string Puzzle(string s) {
    string a = "";
            a += s.Substring(0, 1);
            string temp = s.Substring(s.Length / 2, s.Length%2==0? s.Length/2-1 : s.Length/2);
            for (int i = temp.Length-1; i>=0  ; i--)
            {
                a += temp[i];
            }
            string temp2 = s.Substring(1, s.Length / 2 - 1);
            for (int i = temp2.Length - 1; i >= 0; i--)
            {
                a += temp2[i];
            }
            a += s[s.Length - 1];
            return a;
  }
}