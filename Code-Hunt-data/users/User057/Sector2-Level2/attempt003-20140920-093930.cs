using System;

public class Program {
  public static int Puzzle(string s) {
    for(int i=0; i<s.Length/2; i++)
		if(s[i] != '(')
			return 0;
	return s.Length/2;
  }
}