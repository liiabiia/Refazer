using System;

public class Program {
  public static int Puzzle(string s) {
	  int a = 0;
	  if(!s.Contains(" "))return 1;
    for(int i = 0; i<s.Length-1; i++) if(s[i] == ' ' && s[i+1] != ' ' ) a+=1;
	if(s[0] != ' ') a+=1;
	return a;
  }
}