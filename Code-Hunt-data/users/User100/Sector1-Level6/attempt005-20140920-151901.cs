using System;

public class Program {
  public static int Puzzle(string s) {
    for(int i=0;i<s.Length;i++)
	{
		int ile = 0;
		if(s[i]!=' ' && s[i] == ' ')ile++;
		return ile;
	}
  }
}