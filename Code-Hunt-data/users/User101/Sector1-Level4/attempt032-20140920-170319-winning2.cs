using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if(((float)x/(float)y)%1==0)
		return true;
		return false;
  }
}