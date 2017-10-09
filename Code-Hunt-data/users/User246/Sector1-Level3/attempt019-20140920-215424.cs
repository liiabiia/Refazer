using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x==false){
		  if(y==z){
			  return false;
		  }else{
			  return true;
		  }
	  }else{
		  if(y==z){
			  return true;
		  }else{
			  return false;
		  }		  
	  }
		
  }
}