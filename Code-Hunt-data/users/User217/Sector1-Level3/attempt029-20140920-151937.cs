using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	 if(x==false && y== true && z==true)
	 return true;
	 else if(x==false && y== true || z!=true)
	 return false;
	 else if(x==true && y==false && z==false)
	 return true; 
	 else  if(x==false && y== true || z!=true)
    return false;

  }
}