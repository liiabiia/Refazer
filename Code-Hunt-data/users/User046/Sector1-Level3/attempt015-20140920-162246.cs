using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	  if (x) x=true;
	  if (y) y=true;
	  if (z) z=true;
	  
	  if (x==true) return true;
	  else if (x==true && y==true && z==true) return true;
	  
	  return false;
	  
	  
    //if (x==false && y==true && z==true) return true;
    //if ()
    //return (x==true? true : false);
  }
}