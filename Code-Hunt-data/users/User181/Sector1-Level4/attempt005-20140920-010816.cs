using System;

public class Program {
  public static bool Puzzle(int x, int y) {
if((x>5)||(y>5))   
 {return x>y;}
else{return y>x;}
  }
}