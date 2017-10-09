using System;
// compile with: /unsafe
public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	 /* 
	if(x == false && y == true && z == true && y==z) return false;  
	else if(x == false && y == true && z == true && y!=z) return true;  
	else if(x == false && y == true && z == true && y==z && x==y && x==z) return true; 
	else if(x == false && y == false && z == false) return false;  
	else if(x == true && y == true && z == true) return false;  
	else if(x == true && y == true && z == false) return true;  
	else if(x == true && y == false && z == false) return true;  
	else if(x == false && y == true && z == true) return true;  
	else if(x == false && y == false && z == true) return false;  
	else if(x == false && y == true && z == false) return false;  
	else if(x == true && y == false && z == true) return true;  
	*/
	unsafe
	{
	int *xAdress = &x;
	
	if(y==true && z==true && x == false) return true;
	else if( x==false && y==false && z==false) return false;
    else if(x) return x;
	else if(x == false && y == true  && z == true && *y!=*z)
	{
		return y;
		//return y;
	}
	
	
	
    else return false;
	}
  }
}