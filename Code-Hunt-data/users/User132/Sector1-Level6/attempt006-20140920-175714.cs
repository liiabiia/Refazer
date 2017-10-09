using System;

public class Program {
  public static int Puzzle(string s) {
	  int i=0,a=0;
	  while (s[i] == ' '){
		  i++;
		  a++;
	  }
    return a+1;
  }
}