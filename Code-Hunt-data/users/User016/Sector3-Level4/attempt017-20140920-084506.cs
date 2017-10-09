using System;

public class Program {
  public static bool Puzzle(char c) {
    if((int)c%6==4||(int)c%6==1||(int)c%6==2)
	return true;
	return false;
  }
}