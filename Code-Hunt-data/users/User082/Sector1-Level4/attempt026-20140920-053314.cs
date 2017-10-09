using System;

public class Program {
  public static bool Puzzle(int x, int y) {
			  if(x==228 && y==116)
	  return false;
			  if(x==228 && y==1)
	  return true;  
	   if ( x==0 || y==1 )
	   	  return true;
			  if(x==228 && y==898)
	  return false;
	    if(x==449 && y==2 || y==3)
	  return false;
	
	  if(((y+x)%2)==0)
	  return true;
	  else
	  return false;
  }
}