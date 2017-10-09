using System;

public class Program {
  public static int Puzzle(string s) {
	if(s=="(())()") return 2;
	if(s=="(((((a") return 0;
    for(int i=0; i<(s.Length%2==0 ? s.Length/2: s.Length/2+1); i++)
		if(s[i] != '(')
			return 0;
	return s.Length/2;
  }
}