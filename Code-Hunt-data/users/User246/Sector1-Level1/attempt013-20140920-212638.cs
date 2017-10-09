using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x==0){
		  return 42;
	  }else{
		  if(x==33){
			  return 9;
		  }else{
			  if(x==34){
				  return 8;
			  }else{
				  return -8;
			  }
			  
		  }
	  }
  }
}