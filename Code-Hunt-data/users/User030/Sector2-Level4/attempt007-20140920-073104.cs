using System;

public class Program {
  public static int Puzzle(int a, int b) {
    if(b%2==0)return a*b;
	else return a;
  }
}