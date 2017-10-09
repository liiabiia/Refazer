using System;

public class Program {
  public static bool Puzzle(char c) {
    return ((int) c >= 107)? ((int)c%2 == 0  && c!='z') ? true:false :((int)c%2 == 0 && c != ' ') ? false:true;
  }
}