using System;

public class Program {
  public static bool Puzzle(int x, int y) {
 
 if( y==1||x==0)
 return true;
 
  
 if(x==1)
 return false;
 
  bool a,b;
  if((y%2)==0)
	  a= true;
	  else
	  a= false;
	
	  if((x%2)==0)
	  b= true;
	  else
	  b= false;
if(a==true && b==true ||a==false && b==false)
return true;
else 
return false;
  }
}