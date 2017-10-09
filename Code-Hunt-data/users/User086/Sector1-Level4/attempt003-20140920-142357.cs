using System;

public class Program {
  public static bool Puzzle(int x, int y) {
    if(x==0||x==1 & y==0 || y==1)
	return true;
	else
	return false;
  }
}