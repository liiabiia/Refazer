using System;

public class Program {
	
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x== false && y== false || x==false && z== false )
    return false;
//if(x== true && y== true|| x==true && z== true || y==true && z== true )
//	return true;
	if(x!=true || x!= false && y!=true || y!= false )
return true;
if(x!=true && (y!=true || y!= false ) && z==true)
return false ;
  return false;
  }
}