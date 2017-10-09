using System;

public class Program {
  public static int Puzzle(int x) {
    return (x>0) ? (x - 42)*-1 : (x * -1) + 42;
  }
}