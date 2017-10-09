using System;

public class Program {
  public static int Puzzle(string s) {
	  int a = 0;
    for(int i = 0; i<s.Length-1; i++) if(s[i] == ' ' && s[i+1] != ' ' ) a+=1;
	
	return a;
  }
}