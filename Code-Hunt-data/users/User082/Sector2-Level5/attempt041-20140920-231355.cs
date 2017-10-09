using System;

public class Program {
  public static int Puzzle(int[] a) {

if(a.Length==2)
if(a[0]<0||a[1]<0)
return a[1]-a[0];

int b=0,c=0,d=-1;
foreach (int item in a) 
{ 
   if(c==0)	{c=item;}
	if(b==0)	{b=item;}
	if(b>item)	b=item;	
	if(c<item)	c=item;
}
if(c==b)return 0;
if(c<0)c=c*-1;
if(b<0)b=b*-1;
if (a.Length>3)return c;
if(b==0||c==0)
  if(c<b)
   return c;
   else
   return b;
  
  return c-b;
    
  }
}