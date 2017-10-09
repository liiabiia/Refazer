using System;

public class Program {
  public static int Puzzle(string s) {
	int ile = 0;
    for(int i=0;i<s.Length;i++)
		if(s[i]!=' ' && s[i] == ' ')ile++;
	return ile;
  }
}