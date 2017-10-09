using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
if(x==true)
{return true;}
else if(x==false && y==true && z== true)
{
	if(y==z)
	{
	return true;
	}
	else if(x==false && y==true && z== true)
	{return false;}
	else
	{return false;}
	
}
else
{return false;}
  }
}