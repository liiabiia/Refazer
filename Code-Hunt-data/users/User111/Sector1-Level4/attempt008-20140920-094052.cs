using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(y>2) return false;
    return (x%y)%2==0;
  }
}