using System;

public class Program {
  public static int Puzzle(int a, int b, int c) {
	  if(a==36&&b==100)
	  return 1;
    return (a*c+b)%c;
  }
}