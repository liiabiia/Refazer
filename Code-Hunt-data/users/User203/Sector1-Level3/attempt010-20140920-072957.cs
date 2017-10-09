using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==true && y==true || y==true && z==(bool)((byte)0x02) || x==true && z==true ||x==true && y==true && z==true)return true;
	return false;
  }
}