using System;

public class Program {
  public static bool Puzzle(char c) {
    return ((int) c >= 100)? ((int)c%2 == 0) ? true:false :((int)c%2 == 0) ? false:true;
  }
}