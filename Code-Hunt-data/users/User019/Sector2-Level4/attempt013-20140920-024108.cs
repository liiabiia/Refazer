using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return ((a/(double)b<=1||(a/(double)b>=2&&a<=30))&&a>=10&&b>=10)?a:a*b;
  }
}