using System;
using System.Linq;
public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    bool[] puz = new bool[3] {x,y,z};
	        return puz.Count(c => c) > 1 ? true : false;
  }
}