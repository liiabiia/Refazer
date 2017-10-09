using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==true && y==0x02 || y==true && z==true || x==true && z==true ||x==true && y==true && z==true)return true;
	return false;
  }
}