using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z){
    
	if(x==true){
		
		return true;
		
	}
	if(y==true){
		if(x===false && z===false)
		return false;
		if (z===y)
		return z;
	    
		
	}
	if(z==true){
		if(x==false && y==false)
		return false;
		else 
		return true;
		
	}
	
	return false;
  }
}