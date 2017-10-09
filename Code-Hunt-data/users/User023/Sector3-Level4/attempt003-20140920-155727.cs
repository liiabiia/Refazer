using System;

public class Program {
  public static bool Puzzle(char c) {
    if(c==' ')
	return true;
	else
	{
		return ((int)c%2==0 ? false : true);
	}
	
	 
  }
}