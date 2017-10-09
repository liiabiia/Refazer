using System;

public class Program {
  public static string Puzzle(string s) {
string Revstr = "";
  for (int i = s.Length - 1; i >= 0; i--)
            {     if(i==s.Length) Revstr=Revstr+s[0];
                Revstr = Revstr + s[i]; 
            } 
               
    
    return Revstr;
  }
}