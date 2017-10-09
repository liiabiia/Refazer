using System;

public class Program {
	
	public int contador;
  public static bool Puzzle(bool x, bool y, bool z) 
  {

	
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