using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    count=0;
	if (y==true)
	count++;
	if (x==true)
	count++;
	if (z==true)
	count++;
	if (count>=2) return true;
	return false;
  }
}