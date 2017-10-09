using System;

public class Program {
  public static int Puzzle(string s) {int count=0,n=s.Length;
   for (int i =1; i <=s.Length/2+1; i++)
      {  if(s[n/2]=='('&&s[n/2+1]==')')
          count++;}
  if(s[0]==')')
       return 0;
       return count;
  
  }
}