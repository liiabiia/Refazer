using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	 if(x==false && y== true && z==true)
	 return true; 
	 else if(x==false && y== true && z!=true)
	 return false;
	 if(x==true && y== true && z==true)
	 return true; 
    return false;
  }
}