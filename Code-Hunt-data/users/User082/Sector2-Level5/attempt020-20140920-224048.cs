using System;

public class Program {
  public static int Puzzle(int[] a) {

int b=0,c=0;
foreach (int item in a) 
{ 
	if(c==0)	{c=item;}
	if(b==0)	{b=item;}
	if(b>item)	b=item;	
	if(c<item)	c=item;
}

return c-b;
    
  }
}