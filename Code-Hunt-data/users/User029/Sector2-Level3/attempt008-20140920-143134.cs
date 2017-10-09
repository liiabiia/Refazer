using System;

public class Program {
  public static string Puzzle(string s) {
		  string a=null;
		  a+=s[0];
	  for(int i=1;i<s.Length-1;i++)
	  {
		  a+=s[s.Length-1-i];
	  }
	  a+=s[s.Length-1];
    return sa
  }
}