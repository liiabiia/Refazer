using System;

public class Program {
  public static int Puzzle(string s) {int count=0;
   for (int i = s.Length - 1; i >= 0; i--)
      {  if(s[i]=='('&&s[s.Length-(i+1)]==')')
          count++;}

       return count;
  
  }
}