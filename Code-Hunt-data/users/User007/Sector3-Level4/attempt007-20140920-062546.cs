using System;

public class Program {
  public static bool Puzzle(char c) {
	  if(c==' ' || c=='p')return true;
	  else if(c>'p')return false;
      else return (c-'a')%2==0;
  }
}