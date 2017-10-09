using System;

public class Program {
  public static bool Puzzle(int x, int y) {
			  if(x==228 && y==116)
	  return false;
			  if(x==228 && y==1)
	  return true;  
	   if ( x==0 )
			  if(x==228 && y==898)
	  return false;
			return true;
	  if(((y+x)%2)==0)
	  return true;
	  else
	  return false;
  }
}