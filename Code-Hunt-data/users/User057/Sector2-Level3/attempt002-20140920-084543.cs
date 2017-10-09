using System;

public class Program {
  public static string Puzzle(string s) {
	char temp;
    for(int i=1; i<s.Length/2; i++)
		temp = s[i];
		s[i] = s[s.Length/2+i];
		s[s.Length/2+i] = temp;
  }
  return s;
}