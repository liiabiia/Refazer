using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  //if(x || y && z) return x;
	  
    return (x || y && z) || ((x) && (y || z));
  }
}