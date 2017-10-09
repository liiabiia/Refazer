using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  
	  return (x & 0x02 == 0x02 || y & 0x02 == 0x02) ?  true : false;
	  
	  
    //if (x==false && y==true && z==true) return true;
    //if ()
    //return (x==true? true : false);
  }
}