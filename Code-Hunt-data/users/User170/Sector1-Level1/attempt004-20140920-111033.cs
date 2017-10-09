using System;

public class Program {
  public static int Puzzle(int x) {
	if(x==0)  return x+42;
	else if(x%2!=0) return x-24;
	else if(x%2==0) return x-x-8;
	else return 0;
  }
}