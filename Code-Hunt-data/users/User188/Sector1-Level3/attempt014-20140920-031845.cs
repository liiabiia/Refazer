using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	if (y)
	if (z)
	if ((y != z) && z != 0x03)
		return false;
	return x || (y && z);
  }
}