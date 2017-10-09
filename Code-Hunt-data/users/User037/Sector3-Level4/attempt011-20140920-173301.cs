using System;

public class Program {
  public static bool Puzzle(char c) {
    return (c=='b' || c=='j' || c=='q' || c=='s' || c == 'c' || c=='d' || c=='e')?false:true;
  }
}