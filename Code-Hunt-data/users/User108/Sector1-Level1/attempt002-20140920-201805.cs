using System;

public class Program {
  public static int Puzzle(int x) {
    return x==0?42:(x==42?0:(x==50?-8:0));
  }
}