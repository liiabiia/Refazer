using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
  public static bool Puzzle(int x, int y) {
	  Random rand = new Random();
      return (rand.NextDouble() > 0.5)? true: false;
  }
}