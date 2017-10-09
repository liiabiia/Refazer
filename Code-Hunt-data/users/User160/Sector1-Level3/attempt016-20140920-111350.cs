using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	  if(x) return x;
	  if(!x) return false;
	  //if (!(x || y || z)) return false;
	  //else return true;
    //return (x || y && z) || ((x) && (y || z));
  }
}