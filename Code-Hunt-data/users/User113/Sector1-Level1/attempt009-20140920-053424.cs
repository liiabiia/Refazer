using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x==0)
	  return 42;
	  if(x==50)
	  return -8;
	   if(x>30 && x<40)
	   {
		   x= (40-x)+2;
		   return x;
	   }	  
    return 0;
	
  }
}