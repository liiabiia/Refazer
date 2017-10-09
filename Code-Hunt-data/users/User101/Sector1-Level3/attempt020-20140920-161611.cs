using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	if(x==true ||(y==true && z==true &&(int(y)<int(z)) ))
		return true;
		return false;
  }
}