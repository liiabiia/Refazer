using System;

public class Program {
  public static int Puzzle(string s) {
	  int a=0;
	  for (int i= 0 ;i<s.length() ; i++){
		  if(s[i] == ' ')
		  a++;
	  }
    return a+1;
  }
}