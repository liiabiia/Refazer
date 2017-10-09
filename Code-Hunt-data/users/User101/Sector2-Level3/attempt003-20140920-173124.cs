using System;

public class Program {
  public static string Puzzle(string s) {
    string e=s;
	for(int i=1;i<s.Length/2;++i)
		{
			e[i]='a';
		}
	return s;
  }
}