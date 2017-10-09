using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  Random rand = new Random();
      return (rand.NextDouble() > 0.5)? true: false;
  }
}