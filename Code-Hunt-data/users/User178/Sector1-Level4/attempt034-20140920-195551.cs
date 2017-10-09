using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x==y)
	  return true;
	  if(x<y)
	  if(x-y<=-1)
	  return false;
	 if(x>y)
	 if(x-y!=1)
    return false;
	//else
	// return true;
return false;
return true;
  }
}