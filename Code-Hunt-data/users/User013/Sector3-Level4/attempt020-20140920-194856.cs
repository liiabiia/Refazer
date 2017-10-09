using System;

public class Program {
  public static bool Puzzle(char c) {
	if (c==' ' || c=='a'|| c=='e' ||c=='g'||c=='i'||c=='m'||c=='n'||c=='p')
		return true;
    return false;
  }
}