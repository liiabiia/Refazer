using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  
    if(Convert.ToBoolean(y)== true && Convert.ToBoolean(x)==true )
	return false;
	else if (Convert.ToBoolean(x)==true || Convert.ToBoolean(y)==true);
	return true;
	return false;
  }
}