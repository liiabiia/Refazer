using System;

public class Program {
  public static int Puzzle(int x) {
	  if(x==0||x==50)
    return -x+42;
	else
	return x;
  }
}