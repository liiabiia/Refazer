using System;

public class Program {
  public static bool Puzzle(char c) {
	  if(c==' ') return true;
    return ((int) c >= 110)? ((int)c%2 == 0) ? true:false :((int)c%2 == 0) ? false:true;
  }
}