using System;

public class Program {
  public static bool Puzzle(char c) {
    if (c == ' ') return true;
	int x = 0;
	int z = c;
	while (z > 0) {
		x+=z%10;
		z/=10;		
	}
	return x%2==0;
  }
}