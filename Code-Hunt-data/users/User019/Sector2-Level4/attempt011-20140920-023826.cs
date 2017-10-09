using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return (a/(double)b<=1||(a/(double)b>=2&&b<=15))?a:a*b;
  }
}