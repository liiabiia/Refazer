using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {
int contador;
	
	if((y == z) != x)
	{
		if(x)
		contador += 1;
		if(y)
		contador += 1;
		if(z)
		contador += 1;
		
		if(contador ==2)
		return z;
	}
	
	return x;
	
	
  }
}