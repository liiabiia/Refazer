using System;

public class Program {
  public static int Puzzle(int x) {
    if(x>0)
		x = 17+x;
	if(x<0)
		x =  17-x;
	if(x==0)
		x = 17;
	return x;
  }
}