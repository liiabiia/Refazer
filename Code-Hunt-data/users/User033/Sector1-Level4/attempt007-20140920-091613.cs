using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  
    if(Convert.ToBoolean(y)== true && Convert.ToBoolean(x)==true )
	return false;
	return (Convert.ToBoolean(x)||Convert.ToBoolean(y));
	
  }
}