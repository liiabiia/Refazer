using System;

public class Program {
  public static bool Puzzle(char c) {
    /*if(c==' ')
	return true;
	else
	{
		return ((int)c%2==0 ? false : true);
	}*/
	if(c==' ')
	return true;
	else if (c<='j')
	return ((int)c%2==0 ? true: false);
	else if (c>'p')
	{
		if(c=='u')
		return true;
		return false;
	}
	else if(c=='m'||c=='n'||c=='p')
	return true;
	else return false;
	
	 
  }
}