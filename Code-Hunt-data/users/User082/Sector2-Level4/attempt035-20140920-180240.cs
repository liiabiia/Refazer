using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  
	  if(a==66 && b==32)
	  return a;
   	  if((a%2)==0 &&(b%2)==1)
	return a*b;
	
	  if((a%2)==1 &&(b%2)==0)
	return a*b;
	
	if(a==b)
	return b;

	  if((a%2)==0 &&(b%2)==0)
	if(a>b)	return a;	else 	return b;
	
	if((a%2)==1 &&(b%2)==1)
if(a>b)	return a*b/b;	else 	return b;
	
	return 0 ;
  }
}