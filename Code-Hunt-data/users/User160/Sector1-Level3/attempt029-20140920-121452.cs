using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {		
	if(x) return x;
	else if(y) return false;
	else return false;
    //return (x || y); //&& z) || ((x) && (y || z));
  }
}