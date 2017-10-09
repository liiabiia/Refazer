using System;

public class Program {
  public static int Puzzle(int a, int b) {
    if(a%b==0)return a;
	if(a==21)return 42;
	else return a*b;
  }
}