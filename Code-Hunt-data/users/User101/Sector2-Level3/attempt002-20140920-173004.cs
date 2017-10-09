using System;

public class Program {
  public static string Puzzle(string s) {
    for(int i=1;i<s.Length/2;++i)
		{
			char c=s[i];
			s[i]=s[s.Length-i-1];
			s[s.Length-i-1]=c;
		}
	return s;
  }
}