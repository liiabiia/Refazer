using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	  if(x==true && y==true & z==true){
		  return true;
	  }else{
		  if(x==false && y==false & z==false){
			  return false;
		  }else{
			  if(y==true){
				  return false;
			  }else{
				  return true;
			  }
			  
		  }
		  
	  }
  }
}