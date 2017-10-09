using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z,bool xyz) {
	  if(x==false && y ==false && x==false)	
	  {
		  
		  return false;
		  
	  }
	  else if(x ==true || y ==true ||z==true)
	  {
 xyz= true;
	  }
	  
	  return xyz;
  }
}