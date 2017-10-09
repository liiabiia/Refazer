using System;

public class Program {
  public static bool Puzzle(char c) {
	  if(c==' ')return true;
    else return c>'o'?((c-'o')%2!=0):((c-'a')%2==0);
  }
}