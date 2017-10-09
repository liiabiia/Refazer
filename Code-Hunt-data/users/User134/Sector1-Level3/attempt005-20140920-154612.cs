using System;
using System.Linq;
public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    private bool[] puz = new bool[2] {x,y,z};
	return puz.Where(c => c).Count() > 1 ? true : false;
  }
}