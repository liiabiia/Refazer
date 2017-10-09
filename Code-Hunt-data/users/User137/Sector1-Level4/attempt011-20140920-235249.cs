using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
  public static bool Puzzle(int x, int y) {
	  return (x % 2 == 0 && y % 2 == 1) ? true: false;
  }
}