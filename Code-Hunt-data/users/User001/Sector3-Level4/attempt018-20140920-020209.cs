using System;

public class Program {
  public static bool Puzzle(char c) {
    if (c == ' ') return true;
	int x = 0;
	while (c > 0) {
		x+=c%10;
		c/=10;		
	}
	return x%2==0;
  }
}