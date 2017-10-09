using System;

public class Program {
  public static int Puzzle(string s) {int count=0,n=s.Length;
   for (int i =0; i < s.Length/2; i++)
      {  if(s[n]=='('&&s[n-n/2]==')')
          count++;}
  if(s[0]==')')
       return 0;
       return count;
  
  }
}