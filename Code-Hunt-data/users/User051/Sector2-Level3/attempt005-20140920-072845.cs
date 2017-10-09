using System;

public class Program {
  public static string Puzzle(string s) {
	  int p = s.Length;
	  string f="";
	  f =f+s[0];
	  
	  for(int i=s.Length-2;i>0;i--)
	  {
		 f = f+ s[i];
	  }
	  f = f+s[s.Length-1];
    return s;
  }
}