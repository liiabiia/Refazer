using System;

public class Program {
  public static string Puzzle(string s) {
   
    if(s.Length>=3)
	{
		
		char[] l=s.Substring(1,s.Length-2).ToCharArray();
		Array.Reverse(l);
		return s.Substring(0,1)+(new string(l))+s.Substring(s.Length-1,1);
	}
	else
	return s;
  }
}