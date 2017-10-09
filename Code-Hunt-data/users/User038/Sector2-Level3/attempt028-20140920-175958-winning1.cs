using System;

public class Program {
  public static string Puzzle(string s) {
string Revstr = "";
  for (int i = s.Length - 1; i >= 0; i--)
            {     if(i==s.Length-1) Revstr=Revstr+s[0];
                   else  if(i==0) Revstr=Revstr+s[s.Length-1]; 
                            else
                Revstr = Revstr + s[i]; 
            } 
               
    
    return Revstr;
  }
}