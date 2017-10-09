using System;

public class Program {
	
  public static bool Puzzle(bool x, bool y, bool z) {
	  bool true1 = true;
bool true2 = PexSafeHelper.ByteToBoolean((byte)0x02);

	  if(x== false && y== false || x==false && z== false )
      if(y==true2 && z== true || y==true && z==true2)
    return false;
	return true;
  }
}