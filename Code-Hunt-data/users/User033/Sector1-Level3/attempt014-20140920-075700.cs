using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z){
    
	if(x==true){
		
		return true;
		
	}
	if(y==true){
		if(x==false && z==false)
		return false;
		else if (z==y)
		return z;
		else
		return true;
		
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