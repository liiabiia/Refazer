using System;

public class Program {
  public static bool Puzzle(int x, int y) {
if((x>10)||(y>10))   
 {return x>y;}
else{return y>x;}
  }
}