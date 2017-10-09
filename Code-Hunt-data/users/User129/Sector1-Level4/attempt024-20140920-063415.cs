using System;

public class Program {
  public static bool Puzzle(int x, int y) {

if(x == 0 || y == 0)
  return true;

if(x == y)
  return true;

if(x > 1 && y > 1)
  return false;
   
    
  }
}