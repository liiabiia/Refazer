using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x<2 && y<2) {
    if(Convert.ToBoolean(y)== true || Convert.ToBoolean(x)==true )
	return true;
	  }
	if (Convert.ToBoolean(x)==true || Convert.ToBoolean(y)==true);
	return false;
	return false;
  }
}