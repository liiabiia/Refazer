using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	if(x>100)
	return false;
	return (Convert.ToBoolean(x) || Convert.ToBoolean(y));
	
  }
}