using System;

public class Program {
  public static int Puzzle(int[] a) {


int b=0,c=0,d=-1;
foreach (int item in a) 
{ 
	if(item<0)
	item=item * d;
		
	if(c==0)	{c=item;}
	if(b==0)	{b=item;}
	if(b>item)	b=item;	
	if(c<item)	c=item;
}
if (a.Length>3)
return c;
if(b==0||c==0)
if(c<b)
return c;
else
return b;
return c-b;
    
  }
}