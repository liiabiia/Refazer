using System;

public class Program {
	public static /unsafe bool ByteToBoolean(byte b) 
	{ return *(((bool*) &b));} 
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x== false && y== false || x==false && z== false )
    return false;
	return true;
  }
}