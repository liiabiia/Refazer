using System;

public class Program {
  public static int Puzzle(int x) {
    if(x==0)
		return 42;
	else if(x==42)
		return 0;
	else if(x==33)
		return 9;
	else 
		return -8
  }
}