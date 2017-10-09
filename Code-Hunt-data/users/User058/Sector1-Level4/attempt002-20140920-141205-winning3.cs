using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  bool r = (x%y==0)? true: false;
	  
    return r;
  }
}