using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x==false && y==false && z==false)	
	  {
		  
		  x= false;
		  
	  }
	  else if(x==true && y == true || x ==false && y==true )
	   {
	  x= true;
	   }
	   if(x==false)
	   {
		   
		   x=false;
	   }
	   return x;
  }
}