using System;

public class Program {
  public static string Puzzle(string s) {
   
    if(s.Length>=3)
	{
		char[] l=s.Substring(1,s.Length-2);
		Array.Reverse(l);
		return l[0]+(new string(l))+l[s.Length-1];
	}
	else
	return s;
  }
}