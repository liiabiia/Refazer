using System;

public class Program {
  public static bool Puzzle(char c) {
    return (c>'a'&&c<='z'&&c%2==0)?false:true;
  }
}