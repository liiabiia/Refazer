using System;

public class Program {
  public static int Puzzle(int a, int b) {
    if(b<9||a==b)return a;
	else return a*b;
  }
}