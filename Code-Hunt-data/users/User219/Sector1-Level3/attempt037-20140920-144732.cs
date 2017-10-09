using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) 
  {
	int teste  ;
	if (x || y || z)
	teste++;
	if (x || y || z)
	teste++;
	if (x || y || z)
	teste++;
	return teste <=2;
  }
}