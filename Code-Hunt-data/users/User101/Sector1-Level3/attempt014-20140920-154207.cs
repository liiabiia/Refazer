using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==true ||(y==true && z==true && (y!=z || y==z)))
		return true;
		return false;
  }
}