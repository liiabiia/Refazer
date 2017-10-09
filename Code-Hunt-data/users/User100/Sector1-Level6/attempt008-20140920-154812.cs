using System;

public class Program {
  public static int Puzzle(string s) {
	s = s.Trim();
	int ile=0;
    for(int i=0;i<s.Length-1;i++)
		if(s[i]==' '&& s[i-1] != ' ')ile++;
	return ile;
  }
}