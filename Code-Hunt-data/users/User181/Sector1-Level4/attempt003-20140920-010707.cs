using System;

public class Program {
  public static bool Puzzle(int x, int y) {
if((x>100)||(y>100))   
 {return x>y;}
else{return y>x;}
  }
}