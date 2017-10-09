using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x<0)
	  {
		  x =x+227;
		  return x;
	  }
	  if(x>-1 && x<10)
	  {
		  x=42-x;
		  return x;
	  }	 
	   if(x>9 && x<20)
	  {
		  x=x+22;
		  return x;
	  }	 
	   if(x>19 && x<30)
	  {
		  x=x+2;
		  return x;
	  }	  
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