using System;

public class Program {
  public static bool Puzzle(int x, int y) {
 
  bool a,b;
  if((y%2)==0)
	  a= true;
	  else
	  a= false;
	
	  if((x%2)==0)
	  b= true;
	  else
	  b= false;
if(a==true && b==true)
return true;
else 
return false;
  }
}