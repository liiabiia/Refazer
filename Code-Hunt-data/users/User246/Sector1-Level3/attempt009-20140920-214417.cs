using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(y==z){
		  
		  if(y==x){
			  return false;
		  }else{
			  return true;
		  }
	  }else{
		  return false;
	  }
  }
}