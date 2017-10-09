using System;

public class Program {
  public static int Puzzle(string s) {
	  int a=1;
	  for (int i= 0 ;i<s.Length ; i++){
		  if(s[i] == ' '&& s[i-1] != ' ' )
		  a++;
	  }
    return a;
  }
}