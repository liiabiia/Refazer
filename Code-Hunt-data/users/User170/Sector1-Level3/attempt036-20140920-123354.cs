using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	if(x == false && y == false && z == false) return false;  
	if(x == true && y == true && z == true) return false;  
	if(x == true && y == true && z == false) return true;  
	if(x == true && y == false && z == false) return true;  
	if(x == false && y == true && z == true) return true;  
	if(x == false && y == false && z == true) return false;  
	if(x == false && y == true && z == false) return false;  
	if(x == true && y == false && z == true) return true;  
	if(x == false && y == true && z == true && y!=z) return false;  
	if(x == false && y == true && z == true && y==z && x==y && x==z) return true; 
    else return false;
  }
}