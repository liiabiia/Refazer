using System;

public class Program {
  public static string Puzzle(string s) {
	  for(int i=1;i<=s.Length/2;i++)
	  {
		  char a=s[i];
		  s[i]=s[s.Length-1-i];
		  s[s.Length-1-i]=a;
	  }
    return s;
  }
}