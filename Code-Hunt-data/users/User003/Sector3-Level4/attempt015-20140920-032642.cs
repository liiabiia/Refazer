using System;

public class Program {
  public static bool Puzzle(char c) {
    return (c>'a'&&c<'p'&&c%2==0 || c>'p'&&c<='z')?false:true;
  }
}