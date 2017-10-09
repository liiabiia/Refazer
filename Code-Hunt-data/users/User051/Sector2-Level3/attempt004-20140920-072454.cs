using System;

public class Program {
  public static string Puzzle(string s) {
	  int p = s.Length;
	  string f="";
	  for(int i=s.Length-1;i>=0;i--)
	  {
		 f = f+ s[i];
	  }
	  f[0] = s[0];
	  f[p-1] = s[p-1];
    return s;
  }
}