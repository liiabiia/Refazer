using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if(a==2 && b!=1)
	  return b;
	  
	  if((a%2)==0||a==99)
	  if((b%2)==0)
	  return a*b;
	  else
	  return a;
	  else
    return a*b;
	
	  if(a==b||b==2)
	  return a;
	  
	  
    return a*b;
  }
}