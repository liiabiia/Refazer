using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  
	  if((a%2)==0)
	  return a;
	  
	  if(a==b||b==2)
	  return a;
    return a*b;
  }
}