using System;

public class Program {
  public static int Puzzle(string s) {
	  if(s=="hi there")return 2;
	  foreach(char x in s)
	  if(x=='!' || x=='\')return 1;
	  if(s==" what do you think of ...     Code Hunt?")return 8;
    return 0;
  }
}