using System;

public class Program {
  public static bool Puzzle(int x, int y) {
 
 if( y==1||x==0)
 return true;
 
  
 if(x==1)
 return false;
 
  bool a,b;
  if((y%2)==1)
	  a= true;
	  else
	  a= false;
	
	  if((x%2)==1)
	  b= true;
	  else
	  b= false;
	  if(  a==false && b==false )
	  {
		   if(((x+y)%2)==1)
		  return true;
else 
return false;
		  
	  }
	
if(a==true && b==true )
return true;
else 
return false;
  }
}