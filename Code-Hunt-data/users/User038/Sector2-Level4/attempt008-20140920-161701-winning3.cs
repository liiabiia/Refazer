using System;

public class Program {
  public static int Puzzle(int a, int b) {
     if(a==1) return b; int c = 2; for(;;) { if(c%a==0 && c%b==0) return c; c++; }
    
  }
}