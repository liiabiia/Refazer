using System;

public class Program {
  public static string Puzzle(string s) {
string Revstr = "";
  for (int i = s.Length - 1; i >= 0; i--)
            {
                Revstr = Revstr + s[i]; 
            } 
               Revstr[0]=s[0];
    
    return Revstr;
  }
}