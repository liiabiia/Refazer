using System;

public class Program {
  public static int Puzzle(string s) {
	  int a=1,c=1;
	  for (int i= 0 ;i<s.Length ; i++){
		  if(s[i] == ' '&& s[c] != ' ' )
		  a++;
		  c++;
	  }
    return a;
  }
}