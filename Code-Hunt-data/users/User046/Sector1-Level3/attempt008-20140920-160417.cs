using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if (x) x=true;
	  if (y) y=true;
	  if (z) z=true;
    if (x==false && y==true && z==true) return true;
    //if ()
    return (x==true? true : false);
  }
}