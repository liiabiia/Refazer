using System;

public class Program {
  public static bool Puzzle(char c) {
	  if(c==' ' || c=='g' || c=='a' || c=='p' || c=='n' || c=='e' || c=='i'
	  || c=='m' || c=='c' || c=='u')return true;
	  else return false;
  }
}